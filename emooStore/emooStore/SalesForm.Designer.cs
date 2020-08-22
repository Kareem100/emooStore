namespace emooStore
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeBtn = new System.Windows.Forms.Button();
            this.dgv2Container = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilterTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barcodeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modelCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameSection = new System.Windows.Forms.Panel();
            this.nameCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.models = new System.Windows.Forms.Label();
            this.allSales = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv2Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.FilterTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nameSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dgv2Container
            // 
            this.dgv2Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2Container.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv2Container.Controls.Add(this.dgv2);
            this.dgv2Container.Controls.Add(this.FilterTable);
            this.dgv2Container.Location = new System.Drawing.Point(60, 90);
            this.dgv2Container.Name = "dgv2Container";
            this.dgv2Container.Size = new System.Drawing.Size(492, 240);
            this.dgv2Container.TabIndex = 17;
            this.dgv2Container.Visible = false;
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Model1,
            this.Quantity,
            this.Price,
            this.Barcode1,
            this.Date});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.Location = new System.Drawing.Point(0, 45);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(492, 195);
            this.dgv2.TabIndex = 6;
            // 
            // Namee
            // 
            this.Namee.DataPropertyName = "Namee";
            this.Namee.HeaderText = "الاسم";
            this.Namee.Name = "Namee";
            // 
            // Model1
            // 
            this.Model1.DataPropertyName = "Model";
            this.Model1.HeaderText = "الموديل";
            this.Model1.Name = "Model1";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "الكمية";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            // 
            // Barcode1
            // 
            this.Barcode1.DataPropertyName = "Barcode";
            this.Barcode1.HeaderText = "الباركود";
            this.Barcode1.Name = "Barcode1";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "التاريخ";
            this.Date.Name = "Date";
            // 
            // FilterTable
            // 
            this.FilterTable.ColumnCount = 3;
            this.FilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilterTable.Controls.Add(this.panel2, 2, 0);
            this.FilterTable.Controls.Add(this.panel1, 1, 0);
            this.FilterTable.Controls.Add(this.nameSection, 0, 0);
            this.FilterTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterTable.Location = new System.Drawing.Point(0, 0);
            this.FilterTable.Name = "FilterTable";
            this.FilterTable.RowCount = 1;
            this.FilterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilterTable.Size = new System.Drawing.Size(492, 45);
            this.FilterTable.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.barcodeCB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 39);
            this.panel2.TabIndex = 2;
            // 
            // barcodeCB
            // 
            this.barcodeCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeCB.FormattingEnabled = true;
            this.barcodeCB.Location = new System.Drawing.Point(1, 8);
            this.barcodeCB.Name = "barcodeCB";
            this.barcodeCB.Size = new System.Drawing.Size(115, 21);
            this.barcodeCB.TabIndex = 1;
            this.barcodeCB.SelectedIndexChanged += new System.EventHandler(this.barcodeCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "الباركود:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.modelCB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(167, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 39);
            this.panel1.TabIndex = 1;
            // 
            // modelCB
            // 
            this.modelCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelCB.FormattingEnabled = true;
            this.modelCB.Location = new System.Drawing.Point(3, 8);
            this.modelCB.Name = "modelCB";
            this.modelCB.Size = new System.Drawing.Size(117, 21);
            this.modelCB.TabIndex = 1;
            this.modelCB.SelectedIndexChanged += new System.EventHandler(this.modelCB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "الموديل:";
            // 
            // nameSection
            // 
            this.nameSection.Controls.Add(this.nameCB);
            this.nameSection.Controls.Add(this.label1);
            this.nameSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSection.Location = new System.Drawing.Point(331, 3);
            this.nameSection.Name = "nameSection";
            this.nameSection.Size = new System.Drawing.Size(158, 39);
            this.nameSection.TabIndex = 0;
            // 
            // nameCB
            // 
            this.nameCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameCB.FormattingEnabled = true;
            this.nameCB.Location = new System.Drawing.Point(3, 8);
            this.nameCB.Name = "nameCB";
            this.nameCB.Size = new System.Drawing.Size(119, 21);
            this.nameCB.TabIndex = 1;
            this.nameCB.SelectedIndexChanged += new System.EventHandler(this.nameCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم:";
            // 
            // models
            // 
            this.models.BackColor = System.Drawing.Color.WhiteSmoke;
            this.models.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.models.Cursor = System.Windows.Forms.Cursors.Hand;
            this.models.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.models.Location = new System.Drawing.Point(60, 63);
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(126, 27);
            this.models.TabIndex = 18;
            this.models.Text = "أكثر الموديلات مبيعا: ";
            this.models.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.models.Click += new System.EventHandler(this.models_Click);
            // 
            // allSales
            // 
            this.allSales.BackColor = System.Drawing.Color.Silver;
            this.allSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSales.Location = new System.Drawing.Point(182, 63);
            this.allSales.Name = "allSales";
            this.allSales.Size = new System.Drawing.Size(111, 27);
            this.allSales.TabIndex = 19;
            this.allSales.Text = "عرض كل المبيعات:";
            this.allSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allSales.Click += new System.EventHandler(this.allSales_Click);
            // 
            // dgv1
            // 
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv1.Location = new System.Drawing.Point(60, 90);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(492, 240);
            this.dgv1.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ORDER";
            this.ID.HeaderText = "الترتيب";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "الموديل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dgv2Container);
            this.Controls.Add(this.models);
            this.Controls.Add(this.allSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "SalesForm";
            this.dgv2Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.FilterTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nameSection.ResumeLayout(false);
            this.nameSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel dgv2Container;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.TableLayoutPanel FilterTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox barcodeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox modelCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel nameSection;
        private System.Windows.Forms.ComboBox nameCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label models;
        private System.Windows.Forms.Label allSales;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}