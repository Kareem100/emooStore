using System;
using System.Drawing;
using System.Windows.Forms;

namespace emooStore
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            DateTime firstDay = new DateTime(2020, 7, 23);
            DateTime currentDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day);
            Day.Text = (currentDay - firstDay).TotalDays.ToString();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(childForm);
            bodyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProductForm());
            colorSelctedBtn(addBtn);
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (displaySubmenuPanel.Visible == false) displaySubmenuPanel.Visible = true;
            else displaySubmenuPanel.Visible = false;
            colorSelctedBtn(detailsBtn);
        }

        private void currentProductsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new DisplayProductsForm());
        }
        private void salesProductsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesForm());
        }

        private void returnsBtn_Click(object sender, EventArgs e)
        {
            if (returnSubmenuPanel.Visible == false) returnSubmenuPanel.Visible = true;
            else returnSubmenuPanel.Visible = false;

            colorSelctedBtn(returnsBtn);
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ReceiptForm());
            colorSelctedBtn(billBtn);
        }
        private void barcodeBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new BarcodeForm());
            colorSelctedBtn(barcodeBtn);
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm());
            colorSelctedBtn(employeesBtn);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
            colorSelctedBtn(settingsBtn);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد الخروج من البرنامج ؟", "الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                this.Close();
        }

        private void colorSelctedBtn(Button button)
        {
            addBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            detailsBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            billBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            returnsBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            barcodeBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            employeesBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            settingsBtn.BackColor = Color.FromArgb(1, 11, 7, 17);
            button.BackColor = Color.Black;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            openChildForm(new SoldTodayForm());

        }

        private void Items_Click(object sender, EventArgs e)
        {
            openChildForm(new SoldTodayForm());
        }

        private void purshasedReturnedBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PurshasesReturnedForm());
        }
    }
}
