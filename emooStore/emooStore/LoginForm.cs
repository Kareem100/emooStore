using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emooStore
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public static bool successLogin;
        public LoginForm()
        {
            InitializeComponent();
            successLogin = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passTxt_MouseEnter(object sender, EventArgs e)
        {

        }

        private void passTxt_MouseLeave(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            validateData();
        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                validateData();
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                validateData();
        }
        private void validateData()
        {
            if (nameTxt.Text.Trim() == "admin" && passTxt.Text.Trim() == "admin")
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح \n مرحبا بك " + nameTxt.Text, "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                successLogin = true;
                this.Close();
            }
            else if (!successLogin)
            {
                con.Open();
                cmd.Connection = con;
                
                cmd.CommandText = "SELECT * FROM Admins";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (nameTxt.Text.Trim().Equals(reader["Namee"].ToString()) && passTxt.Text.Trim().Equals(reader["Password"].ToString()))
                    {
                        successLogin = true;
                        MessageBox.Show("تم تسجيل الدخول بنجاح \n مرحبا بك " + nameTxt.Text, "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                reader.Close();
                    con.Close();
                   if(successLogin)this.Close();
                
            }
            if(!successLogin)
                MessageBox.Show("!! ليس هناك ادمن بهذا الاسم", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = "اسـم المـسـتـخـدم";
            passTxt.Text = "كـلـمـة الـمـرور";
        }

        private void nameTxt_Enter(object sender, EventArgs e)
        {
            if(nameTxt.Text == "اسـم المـسـتـخـدم") nameTxt.Text = "";
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") nameTxt.Text = "اسـم المـسـتـخـدم";
        }

        private void passTxt_Enter(object sender, EventArgs e)
        {
            if (passTxt.Text == "كـلـمـة الـمـرور") passTxt.Text = "";
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            if (passTxt.Text == "") passTxt.Text = "كـلـمـة الـمـرور";
        }
    }
}
