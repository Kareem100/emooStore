namespace emooStore
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.newLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.modelTxt = new System.Windows.Forms.ComboBox();
            this.Signature = new System.Windows.Forms.PictureBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.existLbl = new System.Windows.Forms.Label();
            this.existPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.existQuantityTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.existBarcodeTxt = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.table.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.existPanel.SuspendLayout();
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
            this.closeBtn.Location = new System.Drawing.Point(561, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 33);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.Location = new System.Drawing.Point(3, 199);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(218, 35);
            this.browseBtn.TabIndex = 11;
            this.browseBtn.Text = "اختيار الصورة";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // newLbl
            // 
            this.newLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newLbl.Location = new System.Drawing.Point(59, 64);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(89, 27);
            this.newLbl.TabIndex = 0;
            this.newLbl.Text = "مـنـتـج جـديـد:";
            this.newLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newLbl.Click += new System.EventHandler(this.newLbl_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(190, 355);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(219, 41);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "إضـافـة الـمـنـتـج";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // table
            // 
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Controls.Add(this.rightPanel, 0, 0);
            this.table.Controls.Add(this.leftPanel, 1, 0);
            this.table.Location = new System.Drawing.Point(60, 90);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(470, 240);
            this.table.TabIndex = 13;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Controls.Add(this.modelTxt);
            this.rightPanel.Controls.Add(this.Signature);
            this.rightPanel.Controls.Add(this.priceTxt);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.quantityTxt);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.nameTxt);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(229, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(238, 234);
            this.rightPanel.TabIndex = 14;
            // 
            // modelTxt
            // 
            this.modelTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTxt.FormattingEnabled = true;
            this.modelTxt.Location = new System.Drawing.Point(17, 71);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(141, 24);
            this.modelTxt.TabIndex = 3;
            this.modelTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modelTxt_KeyDown);
            // 
            // Signature
            // 
            this.Signature.Image = ((System.Drawing.Image)(resources.GetObject("Signature.Image")));
            this.Signature.Location = new System.Drawing.Point(140, 280);
            this.Signature.Name = "Signature";
            this.Signature.Size = new System.Drawing.Size(250, 100);
            this.Signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Signature.TabIndex = 10;
            this.Signature.TabStop = false;
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTxt.Location = new System.Drawing.Point(17, 180);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(141, 23);
            this.priceTxt.TabIndex = 7;
            this.priceTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTxt_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "سعر القطعة:";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTxt.Location = new System.Drawing.Point(17, 125);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(141, 23);
            this.quantityTxt.TabIndex = 5;
            this.quantityTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantityTxt_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "الكمية:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "الموديل:";
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(17, 17);
            this.nameTxt.MaxLength = 30;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(141, 23);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم:";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.browseBtn);
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(220, 234);
            this.leftPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(217, 179);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // existLbl
            // 
            this.existLbl.BackColor = System.Drawing.Color.Silver;
            this.existLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.existLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.existLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existLbl.Location = new System.Drawing.Point(143, 64);
            this.existLbl.Name = "existLbl";
            this.existLbl.Size = new System.Drawing.Size(101, 27);
            this.existLbl.TabIndex = 14;
            this.existLbl.Text = "مـنـتـج مـوجـود:";
            this.existLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.existLbl.Click += new System.EventHandler(this.existLbl_Click);
            // 
            // existPanel
            // 
            this.existPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.existPanel.Controls.Add(this.label7);
            this.existPanel.Controls.Add(this.existQuantityTxt);
            this.existPanel.Controls.Add(this.label1);
            this.existPanel.Controls.Add(this.existBarcodeTxt);
            this.existPanel.Location = new System.Drawing.Point(60, 90);
            this.existPanel.Name = "existPanel";
            this.existPanel.Size = new System.Drawing.Size(470, 240);
            this.existPanel.TabIndex = 15;
            this.existPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "الـكـمـية:";
            // 
            // existQuantityTxt
            // 
            this.existQuantityTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.existQuantityTxt.Location = new System.Drawing.Point(125, 112);
            this.existQuantityTxt.MaxLength = 12;
            this.existQuantityTxt.Name = "existQuantityTxt";
            this.existQuantityTxt.Size = new System.Drawing.Size(222, 23);
            this.existQuantityTxt.TabIndex = 2;
            this.existQuantityTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.existQuantityTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "الـباركـود:";
            // 
            // existBarcodeTxt
            // 
            this.existBarcodeTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.existBarcodeTxt.Location = new System.Drawing.Point(125, 52);
            this.existBarcodeTxt.MaxLength = 12;
            this.existBarcodeTxt.Name = "existBarcodeTxt";
            this.existBarcodeTxt.Size = new System.Drawing.Size(222, 23);
            this.existBarcodeTxt.TabIndex = 0;
            this.existBarcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.existBarcodeTxt_KeyDown);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.table);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.existPanel);
            this.Controls.Add(this.newLbl);
            this.Controls.Add(this.existLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إضـافـة مـنـتـج";
            this.table.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.existPanel.ResumeLayout(false);
            this.existPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label newLbl;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Signature;
        private System.Windows.Forms.Label existLbl;
        private System.Windows.Forms.Panel existPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox existBarcodeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox existQuantityTxt;
        private System.Windows.Forms.ComboBox modelTxt;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}