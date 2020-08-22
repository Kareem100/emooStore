using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emooStore
{
    public partial class SettingsForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        public SettingsForm()
        {
            InitializeComponent();
            cmd = new SqlCommand();
        }

        private void clearSales_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد مسح جميع المبيعات ؟", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(result == DialogResult.Yes)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM SoldItems";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم مسح جميع المبيعات", "مسح المبيعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearCurrent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد مسح جميع المنتجات ؟", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Item";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم مسح جميع المنتجات", "مسح المنتجات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد مسح جميع الموديلات ؟", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Models";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم مسح جميع الموديلات", "مسح الموديلات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addModel();
        }
        private void addModel()
        {
            if (modelTxt.Text != "")
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Models VALUES ('" + modelTxt.Text.Trim() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                modelTxt.Text = "";
                MessageBox.Show("تم إضافة الموديل", "إضـافـة مـوديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("يجب ادخال موديل", "إضـافـة مـوديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void modelTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) addModel();

        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
