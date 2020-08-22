namespace emooStore
{
    partial class SettingsForm
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
            this.clearSales = new System.Windows.Forms.Button();
            this.clearCurrent = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearSales
            // 
            this.clearSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSales.Location = new System.Drawing.Point(216, 59);
            this.clearSales.Margin = new System.Windows.Forms.Padding(4);
            this.clearSales.Name = "clearSales";
            this.clearSales.Size = new System.Drawing.Size(177, 81);
            this.clearSales.TabIndex = 0;
            this.clearSales.Text = "مـسـح جـمـيـع الـمـبـيـعـات";
            this.clearSales.UseVisualStyleBackColor = true;
            this.clearSales.Click += new System.EventHandler(this.clearSales_Click);
            // 
            // clearCurrent
            // 
            this.clearCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearCurrent.Location = new System.Drawing.Point(216, 148);
            this.clearCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.clearCurrent.Name = "clearCurrent";
            this.clearCurrent.Size = new System.Drawing.Size(177, 81);
            this.clearCurrent.TabIndex = 1;
            this.clearCurrent.Text = "مـسـح الـمـنـتـجـات الـحـالـية";
            this.clearCurrent.UseVisualStyleBackColor = true;
            this.clearCurrent.Click += new System.EventHandler(this.clearCurrent_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(548, 13);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 41);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // modelTxt
            // 
            this.modelTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modelTxt.Location = new System.Drawing.Point(216, 325);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(177, 23);
            this.modelTxt.TabIndex = 4;
            this.modelTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelTxt_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(216, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 81);
            this.button1.TabIndex = 5;
            this.button1.Text = "مـسـح جـمـيـع الـمـوديـلات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(216, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "إضـافـة مـوديـل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearCurrent);
            this.Controls.Add(this.clearSales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearSales;
        private System.Windows.Forms.Button clearCurrent;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}