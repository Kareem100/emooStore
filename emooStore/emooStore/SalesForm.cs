using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace emooStore
{
    public partial class SalesForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dataset;
        public SalesForm()
        {
            InitializeComponent();
            sortModels();
            showAllSales();

            try
            {
                fillNameCombox();
                fillModelCombox();
                fillBarcodeCombox();
            }
            catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك حاول مرة أخرى");
                return;
            }
        }
        private void fillNameCombox()
        {
            nameCB.Items.Clear();
            nameCB.Items.Add("كل الأسماء");
            nameCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Namee FROM SoldItems;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nameCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }
        private void fillModelCombox()
        {
            modelCB.Items.Clear();
            modelCB.Items.Add("كل الموديلات");
            modelCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Model FROM SoldItems;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                modelCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }
        private void fillBarcodeCombox()
        {
            barcodeCB.Items.Clear();
            barcodeCB.Items.Add("كل المتاح");
            barcodeCB.SelectedIndex = 0;
            cmd = new SqlCommand("SELECT DISTINCT Barcode FROM SoldItems;", con);
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                barcodeCB.Items.Add(reader.GetString(0));
            }
            reader.Close();
            con.Close();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void models_Click(object sender, EventArgs e)
        {
            models.BackColor = Color.WhiteSmoke;
            allSales.BackColor = Color.Silver;
            dgv1.Visible = true;
            dgv2Container.Visible = false;
        }

        private void allSales_Click(object sender, EventArgs e)
        {
            models.BackColor = Color.Silver;
            allSales.BackColor = Color.WhiteSmoke;
            dgv1.Visible = false;
            dgv2Container.Visible = true;
        }

        private void sortModels()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT Model, COUNT(Model) AS 'ORDER' FROM SoldItems GROUP BY Model HAVING COUNT(Model) > 0 ORDER BY COUNT(Model) DESC;", con);
                dataset = new DataTable();
                adapter.Fill(dataset);
                dgv1.DataSource = dataset;
            }
            catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك حاول مرة أخرى");
                return;
            }
        }

        private void showAllSales()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM SoldItems", con);
                dataset = new DataTable();
                adapter.Fill(dataset);
                dgv2.DataSource = dataset;
            }
            catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك حاول مرة أخرى");
                return;
            }
        }

        private void nameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           filterData();
        }
        private void modelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void barcodeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           filterData();
        }

        private void filterData()
        {
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format(getFilterCmd());
            dgv2.DataSource = DV;
        }

        private string getFilterCmd()
        {
            string NAME = "Namee = '" + nameCB.SelectedItem.ToString() + "'";
            if (modelCB.SelectedIndex != -1)
            {
                string MODEL = "Model = '" + modelCB.SelectedItem.ToString() + "'";
                string BARCODE = "Barcode = '" + barcodeCB.Text.ToString() + "'";
                string total = "";
                if (nameCB.SelectedIndex != 0) total += NAME;
                if (modelCB.SelectedIndex != 0 && total != "") total += (" AND " + MODEL);
                else if (modelCB.SelectedIndex != 0) total += MODEL;
                if (barcodeCB.SelectedIndex != 0 && total != "") total += (" AND " + BARCODE);
                else if (barcodeCB.SelectedIndex != 0) total += BARCODE;
                return total;
            }
            return "";
        }
    }
}
