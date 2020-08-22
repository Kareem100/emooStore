using BarcodeLib;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace emooStore
{
    public partial class BarcodeForm : Form
    {
        Barcode barcode;
        Image img;
        Bitmap bitmap;
        Font font;
        Point point1, point2, point3, point4, point5, point6, point7;
        string BARCODE;
        public BarcodeForm()
        {
            InitializeComponent();
            barcode = new Barcode();
            font = new Font("Arial", 9);
            point1 = new Point(30, 30); // code
            point2 = new Point(92, 42); // type
            point3 = new Point(70, 55); // typeTxt
            point4 = new Point(12, 42); // model
            point5 = new Point(0, 55); // modelTxt
            point6 = new Point(52, 68); // price
            point7 = new Point(52, 80); // priceTxt
            nameTxt.Focus();
        }
        
        
        private void printClicked()
        {
            if (barcodeTxt.TextLength != 11 || !barcodeTxt.Text.All(c => (c >= 48 && c <= 57)))
            {
                MessageBox.Show("!! الباركود يجب ان يكون 12 او 11 رقم ولا يحتوى على حروف", "الباركود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // GET THE CHECK DIGIT
                BARCODE = barcodeTxt.Text;
                int sum=0, oddSum=0, evenSum=0, digit=0;
                for (int i = 1; i <= 11; ++i)
                    if (i % 2 != 0) oddSum += Int32.Parse(BARCODE[i-1].ToString());
                    else evenSum += Int32.Parse(BARCODE[i-1].ToString());
                sum = oddSum * 3 + evenSum; digit = sum % 10; if (digit != 0) digit = 10 - digit;
                BARCODE += digit.ToString();
                
                img = barcode.Encode(TYPE.UPCA, BARCODE);
                barcodeBox.Image = img;
                // PRINT 
                try
                {
                    printDocument.PrintPage += printDocument_PrintPage;
                    printDialog.Document = printDocument;
                    printDocument.PrinterSettings.Copies = short.Parse(copiesTxt.Text);
                    if (printDialog.ShowDialog() == DialogResult.OK)
                        printDocument.Print();
                }
                catch
                {
                    MessageBox.Show("تأكد من وصلة الطابعة و بياناتك المدخلة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            barcodeTxt.Text="";
            nameTxt.Text = "";
            modelTxt.Text = "";
            copiesTxt.Text = "";
            priceTxt.Text = "";
            if (barcodeBox.Image != null)
            {
                barcodeBox.Image.Dispose();
                barcodeBox.Image = null;
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            printClicked();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            bitmap = new Bitmap(barcodeBox.Image, 100, 30);
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

        private void nameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                modelTxt.Focus();
        }
        private void modelTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                copiesTxt.Focus();
        }
        private void copiesTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                priceTxt.Focus();
        }
        private void priceTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                barcodeTxt.Focus();
        }
        private void barcodeTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (barcodeTxt.Text == "")
                    MessageBox.Show("عند انشاء باركود يدويا يجب كتابة الباركود اولا", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    printClicked();
            }
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
