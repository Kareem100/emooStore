using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emooStore
{
    public partial class ReceiptPrintForm : Form
    {
        public ReceiptPrintForm()
        {
            InitializeComponent();
        }

        private void ReceiptPrintForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * From Invoice", con);
            da.Fill(dataSet, dataSet.Tables[0].TableName);

            ReportDataSource reportDataSource = new ReportDataSource("Products", dataSet.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Invoice";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
