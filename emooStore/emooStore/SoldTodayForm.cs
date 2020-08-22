using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emooStore
{
    public partial class SoldTodayForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dataset;
        public SoldTodayForm()
        {
            InitializeComponent();
            try
            {
                int d = DateTime.Now.Day; string day = (d<10) ? "0"+d.ToString(): d.ToString();
                string query = "SELECT * FROM SoldItems WHERE SUBSTRING (Date, 1, 2) = '" + day + "'";
                adapter = new SqlDataAdapter(query, con);
                dataset = new DataTable();
                cmd = new SqlCommand();
                adapter.Fill(dataset);
                dgv.DataSource = dataset;
                getIncome(query);

                fillComboxes();
            }
            catch
            {
                MessageBox.Show("حدث خطأ فى قراءة البيانات \n من فضلك حاول مرة أخرى");
            }
        }
        private void getIncome(string query)
        {
            double total=0;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read()) total += (double)reader.GetDecimal(3);
            reader.Close();
            con.Close();
            incomeLbl.Text = total.ToString();
        }
        private void fillComboxes()
        {
            nameCB.Items.Clear();
            nameCB.Items.Add("كل الأسماء");
            nameCB.SelectedIndex = 0;
            modelCB.Items.Clear();
            modelCB.Items.Add("كل الموديلات");
            modelCB.SelectedIndex = 0;
            barcodeCB.Items.Clear();
            barcodeCB.Items.Add("كل المتاح");
            barcodeCB.SelectedIndex = 0;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT DISTINCT Namee FROM SoldItems";
            reader = cmd.ExecuteReader();
            while (reader.Read()) nameCB.Items.Add(reader.GetString(0));
            reader.Close();
            cmd.CommandText = "SELECT DISTINCT Model FROM SoldItems";
            reader = cmd.ExecuteReader();
            while (reader.Read()) modelCB.Items.Add(reader.GetString(0));
            reader.Close();
            cmd.CommandText = "SELECT DISTINCT Barcode FROM SoldItems";
            reader = cmd.ExecuteReader();
            while (reader.Read()) barcodeCB.Items.Add(reader.GetString(0));
            reader.Close();
            con.Close();
        }

        private void nameCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            filterData();
        }

        private void modelCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            filterData();
        }

        private void barcodeCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            filterData();
        }
        private void filterData()
        {
            DataView DV = new DataView(dataset);
            DV.RowFilter = string.Format(getFilterCmd());
            dgv.DataSource = DV;
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

        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
