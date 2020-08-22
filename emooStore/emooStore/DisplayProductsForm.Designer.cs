namespace emooStore
{
    partial class DisplayProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayProductsForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.oneProduct = new System.Windows.Forms.Label();
            this.allProducts = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
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
            this.dgvContainer = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.Signature = new System.Windows.Forms.PictureBox();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.buttonsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FilterTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nameSection.SuspendLayout();
            this.dgvContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.table1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            // oneProduct
            // 
            this.oneProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oneProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneProduct.Location = new System.Drawing.Point(60, 65);
            this.oneProduct.Name = "oneProduct";
            this.oneProduct.Size = new System.Drawing.Size(111, 27);
            this.oneProduct.TabIndex = 13;
            this.oneProduct.Text = "عرض منتج محدد:";
            this.oneProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oneProduct.Click += new System.EventHandler(this.oneProduct_Click);
            // 
            // allProducts
            // 
            this.allProducts.BackColor = System.Drawing.Color.Silver;
            this.allProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProducts.Location = new System.Drawing.Point(170, 65);
            this.allProducts.Name = "allProducts";
            this.allProducts.Size = new System.Drawing.Size(123, 27);
            this.allProducts.TabIndex = 15;
            this.allProducts.Text = "عرض كل المنتجات:";
            this.allProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allProducts.Click += new System.EventHandler(this.allProducts_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayBtn.Location = new System.Drawing.Point(142, 3);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(210, 41);
            this.displayBtn.TabIndex = 13;
            this.displayBtn.Text = "عرض الـمـنـتـج";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
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
            this.barcodeCB.Size = new System.Drawing.Size(115, 24);
            this.barcodeCB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
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
            this.modelCB.Size = new System.Drawing.Size(117, 24);
            this.modelCB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
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
            this.nameCB.Size = new System.Drawing.Size(119, 24);
            this.nameCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم:";
            // 
            // dgvContainer
            // 
            this.dgvContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvContainer.Controls.Add(this.dgv);
            this.dgvContainer.Controls.Add(this.FilterTable);
            this.dgvContainer.Location = new System.Drawing.Point(60, 90);
            this.dgvContainer.Name = "dgvContainer";
            this.dgvContainer.Size = new System.Drawing.Size(492, 240);
            this.dgvContainer.TabIndex = 16;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namee,
            this.Model1,
            this.Quantity,
            this.Price,
            this.Barcode1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 45);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(492, 195);
            this.dgv.TabIndex = 6;
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
            // table1
            // 
            this.table1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.table1.ColumnCount = 2;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1.Controls.Add(this.InfoPanel, 0, 0);
            this.table1.Controls.Add(this.panel3, 1, 0);
            this.table1.Location = new System.Drawing.Point(60, 90);
            this.table1.Name = "table1";
            this.table1.RowCount = 1;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table1.Size = new System.Drawing.Size(492, 240);
            this.table1.TabIndex = 17;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoPanel.Controls.Add(this.Signature);
            this.InfoPanel.Controls.Add(this.barcodeTxt);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Controls.Add(this.priceTxt);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.quantityTxt);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.modelTxt);
            this.InfoPanel.Controls.Add(this.label9);
            this.InfoPanel.Controls.Add(this.nameTxt);
            this.InfoPanel.Controls.Add(this.label10);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(249, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(240, 234);
            this.InfoPanel.TabIndex = 17;
            // 
            // Signature
            // 
            this.Signature.Image = ((System.Drawing.Image)(resources.GetObject("Signature.Image")));
            this.Signature.Location = new System.Drawing.Point(140, 280);
            this.Signature.Name = "Signature";
            this.Signature.Size = new System.Drawing.Size(250, 100);
            this.Signature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Signature.TabIndex = 11;
            this.Signature.TabStop = false;
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeTxt.Location = new System.Drawing.Point(20, 202);
            this.barcodeTxt.MaxLength = 12;
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(141, 23);
            this.barcodeTxt.TabIndex = 9;
            this.barcodeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeTxt_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "الباركود:";
            // 
            // priceTxt
            // 
            this.priceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTxt.Location = new System.Drawing.Point(20, 157);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(141, 23);
            this.priceTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "سعر القطعة:";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTxt.Location = new System.Drawing.Point(20, 112);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.ReadOnly = true;
            this.quantityTxt.Size = new System.Drawing.Size(141, 23);
            this.quantityTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "الكمية:";
            // 
            // modelTxt
            // 
            this.modelTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTxt.Location = new System.Drawing.Point(20, 67);
            this.modelTxt.MaxLength = 50;
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.ReadOnly = true;
            this.modelTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.modelTxt.Size = new System.Drawing.Size(141, 23);
            this.modelTxt.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "الموديل:";
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(20, 22);
            this.nameTxt.MaxLength = 30;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(141, 23);
            this.nameTxt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "الاسم:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 234);
            this.panel3.TabIndex = 18;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(3, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(234, 203);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Location = new System.Drawing.Point(358, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(131, 41);
            this.updateBtn.TabIndex = 18;
            this.updateBtn.Text = "تـحـديـث الـمـنـتـج";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Location = new System.Drawing.Point(3, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(133, 41);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "مـسـح الـمـنـتـج";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // buttonsTable
            // 
            this.buttonsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTable.ColumnCount = 3;
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.buttonsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.buttonsTable.Controls.Add(this.deleteBtn, 2, 0);
            this.buttonsTable.Controls.Add(this.updateBtn, 0, 0);
            this.buttonsTable.Controls.Add(this.displayBtn, 1, 0);
            this.buttonsTable.Location = new System.Drawing.Point(60, 353);
            this.buttonsTable.Name = "buttonsTable";
            this.buttonsTable.RowCount = 1;
            this.buttonsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTable.Size = new System.Drawing.Size(492, 47);
            this.buttonsTable.TabIndex = 20;
            // 
            // DisplayProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(609, 421);
            this.Controls.Add(this.buttonsTable);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.dgvContainer);
            this.Controls.Add(this.oneProduct);
            this.Controls.Add(this.allProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayProductsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "DisplayProductsForm";
            this.FilterTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nameSection.ResumeLayout(false);
            this.nameSection.PerformLayout();
            this.dgvContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.table1.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Signature)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.buttonsTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label oneProduct;
        private System.Windows.Forms.Label allProducts;
        private System.Windows.Forms.Button displayBtn;
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
        private System.Windows.Forms.Panel dgvContainer;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Signature;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TableLayoutPanel buttonsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode1;
    }
}