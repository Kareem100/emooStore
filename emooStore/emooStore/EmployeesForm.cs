using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace emooStore
{
    public partial class EmployeesForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || passTxt.Text == "")
                 MessageBox.Show("!!من فضلك ادخل اسم مستخدم و كلمة مرور", "الحقول فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Admins Values (@Namee, @Password)";
                cmd.Parameters.Add(new SqlParameter("@Namee", nameTxt.Text));
                cmd.Parameters.Add(new SqlParameter("@Password", passTxt.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم تسجيل الموظف بنجاح", "نجاح الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            if (nameTxt.Text == "")
                MessageBox.Show("!!من فضلك ادخل اسم المستخدم اللذى تريد حذفه", "الحقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Namee FROM Admins";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (nameTxt.Text.Trim().Equals(reader["Namee"].ToString()))
                    {
                        deleted = true;
                        MessageBox.Show("تم الحذف بنجاح", " عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                reader.Close();
                if (deleted)
                {
                    cmd.CommandText = "DELETE FROM Admins Where Namee = '" + nameTxt.Text.Trim() + "'";
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                if (!deleted)
                {
                    MessageBox.Show("!!ليس هناك موظف بهذا الاسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addDeleteLbl_Click(object sender, EventArgs e)
        {
            addDeleteLbl.BackColor = Color.WhiteSmoke;
            updateLbl.BackColor = Color.Silver;

            updatePanel.Visible = false;
            addDeletePanel.Visible = true;
        }

        private void updateLbl_Click(object sender, EventArgs e)
        {
            addDeleteLbl.BackColor = Color.Silver;
            updateLbl.BackColor = Color.WhiteSmoke;
            addDeletePanel.Visible = false;
            updatePanel.Visible = true;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (currentNameTxt.Text == "" || currentPassTxt.Text == "" || newNameTxt.Text == "" || newPassTxt.Text == "")
                MessageBox.Show("!!من فضلك ادخل الحقول الفارغة", "حقول فارغة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool found = false;
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Admins";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    if (currentNameTxt.Text.Trim().Equals(reader["Namee"].ToString()) && currentPassTxt.Text.Trim().Equals(reader["Password"].ToString()))
                    {
                        found = true;
                        break;
                    }

                reader.Close();
                if (found)
                {
                    cmd.CommandText = "UPDATE Admins set Namee = '" + newNameTxt.Text.Trim() + "', Password = '" + newPassTxt.Text.Trim() + "' WHERE Namee = '" + currentNameTxt.Text.Trim() +"'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("!!ليس هناك موظف بالاسم وكلمة المرور الحاليين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                con.Close();
            }
        }
    }
}
