using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace emooStore
{
    public partial class PurshasesReturnedForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        string name, model, barcode;
        int currentQuantity, removedQuantity;
        double price;

        public PurshasesReturnedForm()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.Silver;
            panel1.Visible = true;
            dgv.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Silver;
            label2.BackColor = Color.WhiteSmoke;
            panel1.Visible = false;
            dgv.Visible = true;
            displayAll();
        }
        private void displayAll()
        {
            adapter = new SqlDataAdapter("SELECT * FROM ReturnedPurshasedItems", con);
            DataTable dataset = new DataTable();
            adapter.Fill(dataset);
            dgv.DataSource = dataset;
        }
        private void displayProduct()
        {
            currentQuantity = 0;
            con.Open();
            cmd.CommandText = "SELECT Namee, Model, Quantity, Price FROM Item WHERE Barcode = '" + enteredBarcode.Text.Trim() + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                displayName.Text = reader.GetString(0);
                displayModel.Text = reader.GetString(1);
                displayQuantity.Text = reader.GetInt32(2).ToString();
                displayPrice.Text = reader.GetDecimal(3).ToString();
                name = reader.GetString(0);
                model = reader.GetString(1);
                currentQuantity = reader.GetInt32(2);
                price = (Double)(reader.GetDecimal(3));
                barcode = enteredBarcode.Text.Trim();
            }
            else
            {
                MessageBox.Show("!! المنتج غير متاح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            con.Close();
        }
        private void editProduct()
        {
            removedQuantity = Int32.Parse(enteredQuantity.Text);
            if (currentQuantity - removedQuantity > 0)
            {
                cmd.CommandText = "UPDATE Item SET Quantity = " + (currentQuantity - removedQuantity) + "";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                saveDate();
                MessageBox.Show("تم تسجيل العملية بنجاح", "الاسترجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (currentQuantity - removedQuantity == 0)
            {
                cmd.CommandText = "DELETE FROM Item WHERE Barcode = '" + enteredBarcode.Text + "'";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                saveDate();
                MessageBox.Show("تم تسجيل العملية بنجاح", "الاسترجاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                removedQuantity = -1;
                MessageBox.Show("!! الكمية غير متاحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveDate()
        {
            cmd.CommandText = "INSERT INTO ReturnedPurshasedItems VALUES ('" +  name + "', '" + model + "', " + removedQuantity + ", " + price + ", '" + barcode + "', '" + date.Value.ToString() + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void enteredBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                displayProduct();
                enteredQuantity.Focus();
            }
        }
        private void enteredQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            /*try
            {*/
                if (e.KeyCode == Keys.Enter)
                    editProduct();
            /*}
            catch
            {
                MessageBox.Show("اكتب البيانات مرة أخرى", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
