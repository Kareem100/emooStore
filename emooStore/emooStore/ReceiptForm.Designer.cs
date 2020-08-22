namespace emooStore
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.DDD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DD = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.Signature = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.costLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.ListBox();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.table.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.buttonsTable.SuspendLayout();
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
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
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
            this.table.Location = new System.Drawing.Point(60, 70);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(470, 240);
            this.table.TabIndex = 14;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Controls.Add(this.DDD);
            this.rightPanel.Controls.Add(this.label7);
            this.rightPanel.Controls.Add(this.DD);
            this.rightPanel.Controls.Add(this.B);
            this.rightPanel.Controls.Add(this.Signature);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.D);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.Q);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.Label1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(229, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(238, 234);
            this.rightPanel.TabIndex = 14;
            // 
            // DDD
            // 
            this.DDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DDD.Location = new System.Drawing.Point(13, 186);
            this.DDD.MaxLength = 3;
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(149, 23);
            this.DDD.TabIndex = 12;
            this.DDD.TextChanged += new System.EventHandler(this.DDD_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(59, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "الخصم/قطعة:";
            // 
            // DD
            // 
            this.DD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DD.Location = new System.Drawing.Point(13, 144);
            this.DD.MaxLength = 3;
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(149, 23);
            this.DD.TabIndex = 3;
            this.DD.Visible = false;
            // 
            // B
            // 
            this.B.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B.Location = new System.Drawing.Point(13, 17);
            this.B.MaxLength = 12;
            this.B.Name = "B";
            this.B.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.B.Size = new System.Drawing.Size(149, 23);
            this.B.TabIndex = 1;
            this.B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.B_KeyDown);
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
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "قيمة مالية (ج)";
            // 
            // D
            // 
            this.D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.D.Location = new System.Drawing.Point(13, 144);
            this.D.MaxLength = 3;
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(149, 23);
            this.D.TabIndex = 5;
            this.D.TextChanged += new System.EventHandler(this.D_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "نسبة مئوية(%)";
            // 
            // Q
            // 
            this.Q.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Q.Location = new System.Drawing.Point(13, 62);
            this.Q.MaxLength = 5;
            this.Q.Name = "Q";
            this.Q.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Q.Size = new System.Drawing.Size(149, 23);
            this.Q.TabIndex = 2;
            this.Q.TextChanged += new System.EventHandler(this.Q_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "كمية المنتج:";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(164, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "باركود المنتج:";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.costLbl);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.LB);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(3, 3);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(220, 234);
            this.leftPanel.TabIndex = 0;
            // 
            // costLbl
            // 
            this.costLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.costLbl.AutoSize = true;
            this.costLbl.BackColor = System.Drawing.Color.DarkGray;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLbl.Location = new System.Drawing.Point(20, 204);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(16, 16);
            this.costLbl.TabIndex = 3;
            this.costLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(146, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "السعر الكلى: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "المنتجات المختارة:";
            // 
            // LB
            // 
            this.LB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB.BackColor = System.Drawing.Color.White;
            this.LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 16;
            this.LB.Location = new System.Drawing.Point(3, 38);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(214, 162);
            this.LB.TabIndex = 0;
            this.LB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LB_MouseDoubleClick);
            // 
            // buttonsTable
            // 
            this.buttonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTable.ColumnCount = 3;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonsTable.Controls.Add(this.clearBtn, 2, 0);
            this.buttonsTable.Controls.Add(this.printBtn, 1, 0);
            this.buttonsTable.Controls.Add(this.removeBtn, 0, 0);
            this.buttonsTable.Location = new System.Drawing.Point(60, 330);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.Size = new System.Drawing.Size(470, 57);
            this.buttonsTable.TabIndex = 15;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Location = new System.Drawing.Point(3, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(135, 51);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "مسح اللائحة";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printBtn.Location = new System.Drawing.Point(144, 3);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(182, 51);
            this.printBtn.TabIndex = 11;
            this.printBtn.Text = "طـبـاعـة الفـاتـورة";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBtn.Location = new System.Drawing.Point(332, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(135, 51);
            this.removeBtn.TabIndex = 10;
            this.removeBtn.Text = "مسح المنتج";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.buttonsTable);
            this.Controls.Add(this.table);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الـفـاتـورة";
            this.table.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.buttonsTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.PictureBox Signature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox DD;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.Label label7;
    }
}