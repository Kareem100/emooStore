using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BarcodeLib;
using System.Drawing.Printing;

namespace emooStore
{
    public partial class AddProductForm : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        string imagePath, BARCODE;

        // Barcode
        char[] characters;
        string randomBarcode;
        int k;
        Random r;
        Barcode barcode;
        Image img;
        Bitmap bitmap;
        Font font;
        Point point1, point2, point3, point4, point5, point6, point7;
        PictureBox pictureBox2;

        public AddProductForm()
        {
            InitializeComponent();
            cmd = new SqlCommand();
            imagePath = null;
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT Model From Models";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) modelTxt.Items.Add(reader.GetString(0));
            reader.Close();
            con.Close();

            // BARCODE
            pictureBox2 = new PictureBox();
            pictureBox2.Visible = false;
            characters = "0123456789".ToCharArray();
            randomBarcode = "";
            k = 12;
            r = new Random();
            barcode = new Barcode();
            font = new Font("Arial", 9);
            point1 = new Point(30, 30); // code
            point2 = new Point(92, 42); // type
            point3 = new Point(70, 55); // typeTxt
            point4 = new Point(12, 42); // model
            point5 = new Point(0, 55); // modelTxt
            point6 = new Point(52, 68); // price
            point7 = new Point(52, 80); // priceTxt
            generateBarcode();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور | *.png; *.jpg;";
            if (op.ShowDialog() == DialogResult.OK)
                pictureBox.Image = Image.FromFile(op.FileName);

            imagePath = op.FileName;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addBtnAction();
           if(table.Visible == true)generateBarcode();
        }
        private void addBtnAction()
        {
            if (table.Visible == true && !checkForRep()) newClick();
            else if (table.Visible == false) existClick();
        }

        private void newClick()
        {  
            try
            {
                if (printBarcode()) 
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    if (imagePath != null)
                        cmd.CommandText = "INSERT INTO Item VALUES ('" + nameTxt.Text + "', '" + modelTxt.Text + "', " + Int32.Parse(quantityTxt.Text) + ", " + Int32.Parse(priceTxt.Text) + ", '" + BARCODE + "', '" + imagePath + "')";

                    else
                        cmd.CommandText = "INSERT INTO Item VALUES ('" + nameTxt.Text + "', '" + modelTxt.Text + "', " + Int32.Parse(quantityTxt.Text) + ", " + Int32.Parse(priceTxt.Text) + ", '" + BARCODE + "', 'NULL')";

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("! تمت إضافة المنتج بنجاح ", "اضـافـة الـمـنـتـج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("تأكد من ادخالك للبيانات بطريقة صحيحة و تأكد من وصلة الطابعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            imagePath = null;
            quantityTxt.Text = "";
            existQuantityTxt.Text = "";
        }

        private bool checkForRep()
        {
            bool found = false;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Namee, Model FROM Item";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(0).Equals(nameTxt.Text.Trim()) && reader.GetString(1).Equals(modelTxt.Text.Trim()))
                    {
                        MessageBox.Show("! تم إدخال هذا المنتج من قبل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        found = true;
                        break;
                    }
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("! لم يتم اضافة المنتج \n من فضلك تأكد من المعلومات المدخلة ", "اضـافـة الـمـنـتـج", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return found;
        }
        private void existClick()
        {
            if(existBarcodeTxt.Text == "" || existQuantityTxt.Text == "")
                MessageBox.Show("من فضلك املى الحقول الفارغة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    bool found = false; int currentQuantity = 0, addedAmount = Int32.Parse(existQuantityTxt.Text);

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Namee, Model, Quantity, Price FROM Item WHERE Barcode = '"+existBarcodeTxt.Text.Trim()+"'";
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameTxt.Text = reader.GetString(0);
                        modelTxt.Text = reader.GetString(1);
                        priceTxt.Text = (reader.GetDecimal(3)).ToString();
                        BARCODE = existBarcodeTxt.Text.Trim();
                        currentQuantity = reader.GetInt32(2);
                        found = true;
                        break;
                        
                    }
                    reader.Close();

                    if (printBarcode())
                    {
                        if (found)
                        {
                            currentQuantity += addedAmount;
                            cmd.CommandText = "UPDATE Item SET Quantity = " + currentQuantity + " WHERE Barcode = '" + existBarcodeTxt.Text.Trim() + "'";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم اضافة الكمية", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            img = barcode.Encode(TYPE.UPCA, existBarcodeTxt.Text);
                            pictureBox2.Image = img;
                        }
                        else
                        {
                            MessageBox.Show("المنتج غير موجود", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("حدث خطأ فى إدخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                quantityTxt.Text = "";
                existQuantityTxt.Text = "";
                nameTxt.Text = "";
                modelTxt.Text = "";
                priceTxt.Text = "";
            }
        }
        private void newLbl_Click(object sender, EventArgs e)
        {
            existLbl.BackColor = Color.Silver;
            newLbl.BackColor = Color.WhiteSmoke;
            table.Visible = true;
            existPanel.Visible = false;
            existQuantityTxt.Text = "";
            existBarcodeTxt.Text = "";
            addBtn.Text = "إضـافـة الـمـنـتـج";
        }

        private void existLbl_Click(object sender, EventArgs e)
        {
            existLbl.BackColor = Color.WhiteSmoke;
            newLbl.BackColor = Color.Silver;
            table.Visible = false;
            existPanel.Visible = true;
            quantityTxt.Text = "";
            addBtn.Text = "تـعـديـل الـمـنـتج";
        }

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                modelTxt.Focus();
        }

        private void modelTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                quantityTxt.Focus();
        }

        private void quantityTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                priceTxt.Focus();
        }

        private void priceTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtnAction();
                generateBarcode();
            }
        }

        private void existBarcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                existQuantityTxt.Focus();
            
        }

        private void existQuantityTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtnAction();
            }
                
            
        }

        private void generateBarcode()
        {
            do
            {
                randomBarcode = "";
                for (int i = 0; i < 11; ++i)
                    randomBarcode += characters[r.Next(0, 10)].ToString();
                // GET THE CHECK DIGIT
                int sum = 0, oddSum = 0, evenSum = 0, digit = 0;
                for (int i = 1; i <= 11; ++i)
                    if (i % 2 != 0) oddSum += Int32.Parse(randomBarcode[i - 1].ToString());
                    else evenSum += Int32.Parse(randomBarcode[i - 1].ToString());
                sum = oddSum * 3 + evenSum; digit = sum % 10; if (digit != 0) digit = 10 - digit;
                randomBarcode += digit.ToString();
            } while (!isUnique(randomBarcode));

            BARCODE = randomBarcode;
            img = barcode.Encode(TYPE.UPCA, BARCODE);
            pictureBox2.Image = img;
        }

        private bool isUnique(string barcode)
        {
            bool unique = true;
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Barcode FROM Item";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0).Equals(barcode)) { unique = false; break; }
            }
            reader.Close();
            con.Close();
            return unique;
        }
        private bool printBarcode()
        {
            bool print = false;
            try
            {
                short copies = 0;
                if (quantityTxt.Text != "")
                    copies = short.Parse(quantityTxt.Text);

                else if (existQuantityTxt.Text != "")
                    copies = short.Parse(existQuantityTxt.Text);

                printDocument.PrintPage += printDocument_PrintPage;
                printDialog.Document = printDocument;
                printDocument.PrinterSettings.Copies = copies;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    print = true;
                }
            } catch
            {
                MessageBox.Show("حدث خطأ فى الطباعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                print = false;
            }
            return print;
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bitmap = new Bitmap(pictureBox2.Image, 100, 30);
            e.Graphics.DrawImage(bitmap, 15, 0);
            e.Graphics.DrawString(BARCODE, font, Brushes.Black, point1); 
            e.Graphics.DrawString("النوع", font, Brushes.Black, point2);
            e.Graphics.DrawString(nameTxt.Text.Trim(), font, Brushes.Black, point3);
            e.Graphics.DrawString("الموديل", font, Brushes.Black, point4);
            e.Graphics.DrawString(modelTxt.Text.Trim(), font, Brushes.Black, point5);
            e.Graphics.DrawString("السعر", font, Brushes.Black, point6);
            e.Graphics.DrawString(priceTxt.Text.Trim(), font, Brushes.Black, point7);
            bitmap.Dispose();
        }
    }
}
