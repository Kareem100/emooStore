namespace emooStore
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addDeletePanel = new System.Windows.Forms.Panel();
            this.addDeleteLbl = new System.Windows.Forms.Label();
            this.updateLbl = new System.Windows.Forms.Label();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.newNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentPassTxt = new System.Windows.Forms.TextBox();
            this.currentNameTxt = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(545, 15);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 41);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxt.Location = new System.Drawing.Point(225, 146);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.MaxLength = 20;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(199, 23);
            this.nameTxt.TabIndex = 2;
            // 
            // passTxt
            // 
            this.passTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxt.Location = new System.Drawing.Point(225, 193);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTxt.MaxLength = 20;
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(199, 23);
            this.passTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "الإسم:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "كلمة المرور:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(225, 243);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 32);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "اضـافـة المـوظـف";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Location = new System.Drawing.Point(342, 243);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(82, 32);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "حذف الموظف";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addDeletePanel
            // 
            this.addDeletePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDeletePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addDeletePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDeletePanel.Location = new System.Drawing.Point(132, 101);
            this.addDeletePanel.Name = "addDeletePanel";
            this.addDeletePanel.Size = new System.Drawing.Size(331, 201);
            this.addDeletePanel.TabIndex = 8;
            // 
            // addDeleteLbl
            // 
            this.addDeleteLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addDeleteLbl.AutoSize = true;
            this.addDeleteLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDeleteLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDeleteLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDeleteLbl.Location = new System.Drawing.Point(168, 83);
            this.addDeleteLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addDeleteLbl.Name = "addDeleteLbl";
            this.addDeleteLbl.Size = new System.Drawing.Size(73, 19);
            this.addDeleteLbl.TabIndex = 9;
            this.addDeleteLbl.Text = "اضافة / حذف";
            this.addDeleteLbl.Click += new System.EventHandler(this.addDeleteLbl_Click);
            // 
            // updateLbl
            // 
            this.updateLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateLbl.AutoSize = true;
            this.updateLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateLbl.Location = new System.Drawing.Point(132, 83);
            this.updateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateLbl.Name = "updateLbl";
            this.updateLbl.Size = new System.Drawing.Size(39, 19);
            this.updateLbl.TabIndex = 10;
            this.updateLbl.Text = "تحديث";
            this.updateLbl.Click += new System.EventHandler(this.updateLbl_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.label5);
            this.updatePanel.Controls.Add(this.newPassTxt);
            this.updatePanel.Controls.Add(this.newNameTxt);
            this.updatePanel.Controls.Add(this.label6);
            this.updatePanel.Controls.Add(this.label7);
            this.updatePanel.Controls.Add(this.currentPassTxt);
            this.updatePanel.Controls.Add(this.currentNameTxt);
            this.updatePanel.Controls.Add(this.update);
            this.updatePanel.Location = new System.Drawing.Point(132, 102);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(331, 201);
            this.updatePanel.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "كلمة المرور:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "الاسم الجديد:";
            // 
            // newPassTxt
            // 
            this.newPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPassTxt.Location = new System.Drawing.Point(31, 123);
            this.newPassTxt.Margin = new System.Windows.Forms.Padding(5);
            this.newPassTxt.MaxLength = 20;
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.PasswordChar = '*';
            this.newPassTxt.Size = new System.Drawing.Size(216, 23);
            this.newPassTxt.TabIndex = 21;
            // 
            // newNameTxt
            // 
            this.newNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newNameTxt.Location = new System.Drawing.Point(31, 90);
            this.newNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.newNameTxt.MaxLength = 20;
            this.newNameTxt.Name = "newNameTxt";
            this.newNameTxt.Size = new System.Drawing.Size(216, 23);
            this.newNameTxt.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "كلمة المرور:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "الاسم الحالى:";
            // 
            // currentPassTxt
            // 
            this.currentPassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPassTxt.Location = new System.Drawing.Point(31, 44);
            this.currentPassTxt.Margin = new System.Windows.Forms.Padding(5);
            this.currentPassTxt.MaxLength = 20;
            this.currentPassTxt.Name = "currentPassTxt";
            this.currentPassTxt.PasswordChar = '*';
            this.currentPassTxt.Size = new System.Drawing.Size(216, 23);
            this.currentPassTxt.TabIndex = 17;
            // 
            // currentNameTxt
            // 
            this.currentNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentNameTxt.Location = new System.Drawing.Point(31, 11);
            this.currentNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.currentNameTxt.MaxLength = 20;
            this.currentNameTxt.Name = "currentNameTxt";
            this.currentNameTxt.Size = new System.Drawing.Size(216, 23);
            this.currentNameTxt.TabIndex = 16;
            // 
            // update
            // 
            this.update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(71, 155);
            this.update.Margin = new System.Windows.Forms.Padding(4);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 39);
            this.update.TabIndex = 15;
            this.update.Text = "تـحـديـث الـبـيانـات";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.updateLbl);
            this.Controls.Add(this.addDeleteLbl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addDeletePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "EmployeesForm";
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Panel addDeletePanel;
        private System.Windows.Forms.Label addDeleteLbl;
        private System.Windows.Forms.Label updateLbl;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.TextBox newNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox currentPassTxt;
        private System.Windows.Forms.TextBox currentNameTxt;
        private System.Windows.Forms.Button update;
    }
}