using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace emooStore
{
    public partial class ReceiptForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        ArrayList name = new ArrayList(), model = new ArrayList(), quantity = new ArrayList(), discount = new ArrayList();
        ArrayList quantityAvailable = new ArrayList(), pricePerPiece = new ArrayList(), cost = new ArrayList(), barcode = new ArrayList();
        double totalPrice;

        public ReceiptForm()
        {
            InitializeComponent();
            totalPrice = 0;
            cmd = new SqlCommand();
        }

        private void B_KeyDown(object sender, KeyEventArgs e) 
        { 
            if(e.KeyCode == Keys.Enter)
            {
                bool found = false;
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Namee, Model, Quantity, Price FROM Item WHERE Barcode = @Barcode";
                cmd.Parameters.Add(new SqlParameter("@Barcode", B.Text));
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    barcode.Add(B.Text);
                    name.Add(reader.GetString(0));
                    model.Add(reader.GetString(1));
                    quantity.Add(1);
                    discount.Add(0.0);
                    
                    LB.Items.Add(reader.GetString(0) + " (x1) (%0)");
                    LB.SelectedIndex = LB.Items.Count - 1;

                    quantityAvailable.Add(reader.GetInt32(2));
                    pricePerPiece.Add((double)reader.GetDecimal(3));
                    cost.Add((double)reader.GetDecimal(3));
                    totalPrice += (double) reader.GetDecimal(3);
                    costLbl.Text = totalPrice.ToString();
                    
                    B.Text = "";
                    found = true;
                }
                if (!found) { MessageBox.Show("المنتج غير متاح !!", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error); B.Text = ""; }
                reader.Close();
                con.Close();
            }
        }

        private void Q_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                quantity[LB.SelectedIndex] = Int32.Parse(Q.Text);
                cost[LB.SelectedIndex] = (double)((int)quantity[LB.SelectedIndex] * (double)pricePerPiece[LB.SelectedIndex]);
                LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x" + quantity[LB.SelectedIndex] + ") (%" + discount[LB.SelectedIndex] + ") ";
            }
            catch
            {
                if (LB.SelectedIndex == -1 && Q.Text != "")
                    MessageBox.Show("لم يتم تحديد اى منتح !!", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Q.Text != "")
                    MessageBox.Show("يجب ادخال الكمية كقيمة رقمية !!", "الكمية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (LB.SelectedIndex != -1)
                    {
                        quantity[LB.SelectedIndex] = 0;
                        cost[LB.SelectedIndex] = (double)pricePerPiece[LB.SelectedIndex];
                        LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x1) (%0) ";
                    }
                }
            }
            totalPrice = 0;
            for (int i = 0; i < cost.Count; ++i)
                totalPrice += (double)cost[i];
            costLbl.Text = totalPrice.ToString();
        }
        private void D_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discount[LB.SelectedIndex] = Double.Parse(D.Text);
                if ((double)discount[LB.SelectedIndex] != 0)
                    cost[LB.SelectedIndex] = (double)((int)quantity[LB.SelectedIndex] * ((double)pricePerPiece[LB.SelectedIndex] - (double)pricePerPiece[LB.SelectedIndex] * ((double)discount[LB.SelectedIndex] / 100)));
                LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x" + quantity[LB.SelectedIndex] + ") (%" + discount[LB.SelectedIndex] + ") ";
            }
            catch
            {
                if (LB.SelectedIndex == -1 && D.Text != "")
                    MessageBox.Show("لم يتم تحديد اى منتح !!", "الخصم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (D.Text != "")
                    MessageBox.Show("يجب ادخال الخصم كقيمة رقمية !!", "الخصم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (LB.SelectedIndex != -1)
                    {
                        discount[LB.SelectedIndex] = 0.0;
                        cost[LB.SelectedIndex] = (double) ((double)pricePerPiece[LB.SelectedIndex] * (int)quantity[LB.SelectedIndex]);
                        LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x1) (%0) ";
                    }
                }
            }
            totalPrice = 0;
            for (int i = 0; i < cost.Count; ++i)
                totalPrice += (double)cost[i];
            costLbl.Text = totalPrice.ToString();
        }

        private void DDD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                discount[LB.SelectedIndex] = Double.Parse(DDD.Text);
                if ((double)discount[LB.SelectedIndex] != 0 && (double)discount[LB.SelectedIndex] <= (double)pricePerPiece[LB.SelectedIndex])
                    cost[LB.SelectedIndex] = (double)((int)quantity[LB.SelectedIndex] * ((double)pricePerPiece[LB.SelectedIndex] - (double)discount[LB.SelectedIndex]));
                LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x" + quantity[LB.SelectedIndex] + ") (%" + discount[LB.SelectedIndex] + ") ";
            }
            catch
            {
                if (LB.SelectedIndex == -1 && DDD.Text != "")
                    MessageBox.Show("لم يتم تحديد اى منتح !!", "الخصم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (DDD.Text != "")
                    MessageBox.Show("يجب ادخال الخصم كقيمة رقمية !!", "الخصم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (LB.SelectedIndex != -1)
                    {
                        discount[LB.SelectedIndex] = 0.0;
                        cost[LB.SelectedIndex] = (double)((double)pricePerPiece[LB.SelectedIndex] * (int)quantity[LB.SelectedIndex]);
                        LB.Items[LB.SelectedIndex] = name[LB.SelectedIndex] + " (x1) (%0) ";
                    }
                }
            }
            totalPrice = 0;
            for (int i = 0; i < cost.Count; ++i)
                totalPrice += (double)cost[i];
            costLbl.Text = totalPrice.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            bool success = true;
            totalPrice = 0;
            for (int i = 0; i < cost.Count; ++i)
                totalPrice += (double)cost[i];
            costLbl.Text = totalPrice.ToString();
            for (int i = 0; i < quantity.Count; ++i)
                if ((int)quantity[i] > (int)quantityAvailable[i])
                {
                    success = false;
                    MessageBox.Show("كمية المنتج رقم " + (i+1) +" غير متاحة..", "خطأ ف اختيار المنتجات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (success)
            {
                try
                {
                    int qq;
                    con.Open();
                    cmd.Connection = con;
                    int x = 1;
                    cmd.CommandText = "SELECT ID FROM ReceiptID";
                    reader = cmd.ExecuteReader();
                    if (reader.Read()) x = (1 + reader.GetInt32(0));
                    reader.Close();
                        cmd.CommandText = "UPDATE ReceiptID SET ID = " + x;
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < name.Count; ++i)
                    {
                        qq = (int)quantityAvailable[i] - (int)quantity[i];
                        if (qq == 0)
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "DELETE FROM Item WHERE Namee ='" + name[i].ToString() + "'";
                            cmd.Parameters.Add(new SqlParameter("@Namee", name[i].ToString()));
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "UPDATE Item SET Quantity='" + qq.ToString() + "' WHERE Namee = @Namee";
                            cmd.Parameters.Add(new SqlParameter("@Namee", name[i].ToString()));
                            cmd.ExecuteNonQuery();
                        }
                        /*************************************/ // ADD TO INVOICE 
                        
                        cmd.CommandText = "INSERT INTO Invoice VALUES (" + x + ", '" + (string)name[i] + "', " + (int)quantity[i] + ", " + (double)discount[i] + ", " + (double)cost[i] + ", " + totalPrice + ", '" + DateTime.Now.ToString() + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Invoice";
                    cmd.ExecuteNonQuery();
                }
                
                con.Close();
                addToSoldItems();
                ReceiptPrintForm form = new ReceiptPrintForm();
                form.ShowDialog();
            }
            else MessageBox.Show("عملية غير ناجحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void addToSoldItems()
        {
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.Text;
            for(int i = 0; i < name.Count; ++i)
            {
                cmd.CommandText = "INSERT INTO SoldItems VALUES ('" + (string)name[i] + "', '" + (string)model[i] + "', " + (int)quantity[i] + ", " + (double)cost[i] + ", " + (string)barcode[i] + ", '" + DateTime.Now.ToString() + "')";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void LB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("المنتج: " + name[LB.SelectedIndex] + "\nالكمية: " + quantity[LB.SelectedIndex].ToString() + "\nالخصم: %" + discount[LB.SelectedIndex].ToString());
        }

        private void removeBtn_Click(object sender, System.EventArgs e)
        {
            totalPrice -= (double)cost[LB.SelectedIndex];
            costLbl.Text = totalPrice.ToString();
            name.RemoveAt(LB.SelectedIndex);
            model.RemoveAt(LB.SelectedIndex);
            quantity.RemoveAt(LB.SelectedIndex);
            discount.RemoveAt(LB.SelectedIndex);
            quantityAvailable.RemoveAt(LB.SelectedIndex);
            pricePerPiece.RemoveAt(LB.SelectedIndex);
            cost.RemoveAt(LB.SelectedIndex);
            barcode.RemoveAt(LB.SelectedIndex);
            LB.Items.RemoveAt(LB.SelectedIndex);
        }

        private void clearBtn_Click(object sender, System.EventArgs e)
        {
            name.Clear(); quantity.Clear(); discount.Clear();
            quantityAvailable.Clear(); pricePerPiece.Clear();
            totalPrice = 0; costLbl.Text = "0"; cost.Clear();
            LB.Items.Clear(); model.Clear(); barcode.Clear();
            Q.Text = "";
            D.Text = "";
            DDD.Text = "";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
