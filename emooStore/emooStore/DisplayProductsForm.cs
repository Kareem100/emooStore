using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace emooStore
{
    public partial class DisplayProductsForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dataset;
        string temp, NAME, MODEL, BARCODE, total;

        public DisplayProductsForm()
        {
            InitializeComponent();
            try
            {
                fillNameCombox();
                fillModelCombox();
                fillBarcodeCombox();
                showAll();
            } catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك اغلق البرنامج وعيد تشغيله");
                return;
            }
        }

        private void fillNameCombox()
        {
            nameCB.Items.Clear();
            nameCB.Items.Add("كل الأسماء");
            nameCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Namee FROM Item;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetString(0);
                nameCB.Items.Add(temp);
            }
            reader.Close();
            con.Close();
        }
        private void fillModelCombox()
        {
            modelCB.Items.Clear();
            modelCB.Items.Add("كل الموديلات");
            modelCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Model FROM Item;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetString(0);
                modelCB.Items.Add(temp);
            }
            reader.Close();
            con.Close();
        }
        private void fillBarcodeCombox()
        {
            barcodeCB.Items.Clear();
            barcodeCB.Items.Add("كل المتاح");
            barcodeCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Barcode FROM Item;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetString(0);
                barcodeCB.Items.Add(temp);
            }
            reader.Close();
            con.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oneProduct_Click(object sender, EventArgs e)
        {
            oneProduct.BackColor = Color.WhiteSmoke;
            allProducts.BackColor = Color.Silver;
            updateBtn.Visible = deleteBtn.Visible = false;
            table1.Visible = true;
            displayBtn.Text = "عرض الـمـنـتـج";
        }

        private void allProducts_Click(object sender, EventArgs e)
        {
            oneProduct.BackColor = Color.Silver;
            allProducts.BackColor = Color.WhiteSmoke;
            updateBtn.Visible = deleteBtn.Visible = true;
            table1.Visible = false;
            displayBtn.Text = "عرض الـمـنـتـجـات";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Enter The Password HERE
            con.Open();
            for (int i = 0; i < dgv.Rows.Count-1; ++i)
            {
                cmd = new SqlCommand("WITH ItemCTE AS (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM Item) UPDATE ItemCTE SET Namee = '"+ dgv.Rows[i].Cells[0].Value + "', Model = '"+ dgv.Rows[i].Cells[1].Value + "', Quantity = '"+ dgv.Rows[i].Cells[2].Value.ToString() + "', Price = '"+ dgv.Rows[i].Cells[3].Value.ToString() + "', Barcode = '"+ dgv.Rows[i].Cells[4].Value.ToString() + "' WHERE RowNumber = " + (i + 1), con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            showAll();
            nameCB.SelectedIndex = modelCB.SelectedIndex = barcodeCB.SelectedIndex = 0;
            fillNameCombox(); fillModelCombox(); fillBarcodeCombox();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        { 
            // ENTER THE PASSWORD HERE
            int dec = 0;
            con.Open();
            foreach (DataGridViewRow row in dgv.SelectedRows)
                if (!row.IsNewRow)
                {
                    cmd = new SqlCommand("WITH ItemCTE AS (SELECT *, ROW_NUMBER() OVER (ORDER BY ID) AS RowNumber FROM Item) DELETE FROM ItemCTE WHERE RowNumber = " + (row.Index + 1 - dec), con);
                    cmd.ExecuteNonQuery();
                    dec++;
                }
            con.Close();
            showAll();
            nameCB.SelectedIndex = modelCB.SelectedIndex = barcodeCB.SelectedIndex = 0;
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            if (table1.Visible == true)
                showOne();
            else
                filterData();
        }

        private void barcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                showOne();
        }

        private void showOne()
        {
            bool found = false;
            pictureBox.Image = null;
            cmd = new SqlCommand("SELECT * FROM Item WHERE Barcode = @Barcode", con);
            cmd.Parameters.Add(new SqlParameter("@Barcode", barcodeTxt.Text));
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                found = true;
                nameTxt.Text = reader.GetString(1);
                modelTxt.Text = reader.GetString(2);
                quantityTxt.Text = reader.GetInt32(3).ToString();
                priceTxt.Text = reader.GetDecimal(4).ToString();
                try
                {
                    pictureBox.ImageLocation = reader.GetString(6);
                } catch
                {
                    return;
                }
            }
            reader.Close();
            con.Close();
            if (!found) MessageBox.Show("!! هذا المنتج غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void filterData()
        { 
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format(getFilterCmd());
            dgv.DataSource = DV;
        }

        private string getFilterCmd()
        {
            NAME = "Namee = '" + nameCB.SelectedItem.ToString() + "'";
            MODEL = "Model = '" + modelCB.SelectedItem.ToString() + "'";
            BARCODE = "Barcode = '" + barcodeCB.Text.ToString() + "'";
            total = "";
            if (nameCB.SelectedIndex != 0) total += NAME;
            if (modelCB.SelectedIndex != 0 && total != "") total += (" AND " + MODEL);
            else if (modelCB.SelectedIndex != 0) total += MODEL;
            if (barcodeCB.SelectedIndex != 0 && total != "") total += (" AND " + BARCODE);
            else if (barcodeCB.SelectedIndex != 0) total += BARCODE;

            return total;
        }

        private void showAll()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT Namee, Model, Quantity, Price, Barcode FROM Item", con);
                dataset = new DataTable();
                adapter.Fill(dataset);
                dgv.DataSource = dataset;
            }catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك حاول مرة أخرى");
                return;
            }
        }

    }
}
