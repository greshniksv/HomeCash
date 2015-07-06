namespace HomeCash
{
	partial class FrmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAddPurchase = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbCash = new System.Windows.Forms.ToolStripButton();
			this.tsbProduct = new System.Windows.Forms.ToolStripButton();
			this.tsbTopUp = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CashToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topupMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusSum = new System.Windows.Forms.ToolStripStatusLabel();
			this.gbCashPanel = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.gbPurchase = new System.Windows.Forms.GroupBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.cbOneMore = new System.Windows.Forms.CheckBox();
			this.lsbProduct = new System.Windows.Forms.ListBox();
			this.scbProduct = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbCash = new System.Windows.Forms.ComboBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblAddEdit = new System.Windows.Forms.Label();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txbSum = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbVolume = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbProductFilter = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cbCashFilter = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.lvPurchase = new System.Windows.Forms.ListView();
			this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbPurchase.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddPurchase,
            this.toolStripSeparator1,
            this.tsbCash,
            this.tsbProduct,
            this.tsbTopUp});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1272, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAddPurchase
			// 
			this.tsbAddPurchase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tsbAddPurchase.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddPurchase.Image")));
			this.tsbAddPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAddPurchase.Name = "tsbAddPurchase";
			this.tsbAddPurchase.Size = new System.Drawing.Size(134, 22);
			this.tsbAddPurchase.Text = "Добавить покупку";
			this.tsbAddPurchase.Click += new System.EventHandler(this.tsbAddPurchase_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbCash
			// 
			this.tsbCash.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tsbCash.Image = ((System.Drawing.Image)(resources.GetObject("tsbCash.Image")));
			this.tsbCash.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbCash.Name = "tsbCash";
			this.tsbCash.Size = new System.Drawing.Size(63, 22);
			this.tsbCash.Text = "Счета";
			this.tsbCash.Click += new System.EventHandler(this.tsbCash_Click);
			// 
			// tsbProduct
			// 
			this.tsbProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tsbProduct.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduct.Image")));
			this.tsbProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbProduct.Name = "tsbProduct";
			this.tsbProduct.Size = new System.Drawing.Size(73, 22);
			this.tsbProduct.Text = "Товары";
			this.tsbProduct.Click += new System.EventHandler(this.tsbProduct_Click);
			// 
			// tsbTopUp
			// 
			this.tsbTopUp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tsbTopUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbTopUp.Image")));
			this.tsbTopUp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTopUp.Name = "tsbTopUp";
			this.tsbTopUp.Size = new System.Drawing.Size(99, 22);
			this.tsbTopUp.Text = "Пополнения";
			this.tsbTopUp.Click += new System.EventHandler(this.tsbTopUp_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1272, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// управлениеToolStripMenuItem
			// 
			this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CashToolStripMenuItem1,
            this.ProductToolStripMenuItem,
            this.topupMenuToolStripMenuItem});
			this.управлениеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
			this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
			this.управлениеToolStripMenuItem.Text = "Управление";
			// 
			// CashToolStripMenuItem1
			// 
			this.CashToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("CashToolStripMenuItem1.Image")));
			this.CashToolStripMenuItem1.Name = "CashToolStripMenuItem1";
			this.CashToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
			this.CashToolStripMenuItem1.Text = "Счета";
			this.CashToolStripMenuItem1.Click += new System.EventHandler(this.CashToolStripMenuItem1_Click);
			// 
			// ProductToolStripMenuItem
			// 
			this.ProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductToolStripMenuItem.Image")));
			this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
			this.ProductToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.ProductToolStripMenuItem.Text = "Товары";
			this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
			// 
			// topupMenuToolStripMenuItem
			// 
			this.topupMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("topupMenuToolStripMenuItem.Image")));
			this.topupMenuToolStripMenuItem.Name = "topupMenuToolStripMenuItem";
			this.topupMenuToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.topupMenuToolStripMenuItem.Text = "Пополнения";
			this.topupMenuToolStripMenuItem.Click += new System.EventHandler(this.topupMenuToolStripMenuItem_Click);
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(102, 21);
			this.оПрограммеToolStripMenuItem.Text = "О программе";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSum});
			this.statusStrip1.Location = new System.Drawing.Point(0, 641);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1272, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusSum
			// 
			this.toolStripStatusSum.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripStatusSum.Name = "toolStripStatusSum";
			this.toolStripStatusSum.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusSum.Text = "Cevvf 1258.56";
			// 
			// gbCashPanel
			// 
			this.gbCashPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbCashPanel.Location = new System.Drawing.Point(16, 54);
			this.gbCashPanel.Margin = new System.Windows.Forms.Padding(4);
			this.gbCashPanel.Name = "gbCashPanel";
			this.gbCashPanel.Padding = new System.Windows.Forms.Padding(4);
			this.gbCashPanel.Size = new System.Drawing.Size(1240, 84);
			this.gbCashPanel.TabIndex = 3;
			this.gbCashPanel.TabStop = false;
			this.gbCashPanel.Text = "Счета";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.txbProductFilter);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.cbCashFilter);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpEnd);
			this.groupBox2.Controls.Add(this.dtpStart);
			this.groupBox2.Controls.Add(this.lvPurchase);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(16, 146);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1240, 486);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Покупки";
			// 
			// gbPurchase
			// 
			this.gbPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbPurchase.Controls.Add(this.dtpDate);
			this.gbPurchase.Controls.Add(this.cbOneMore);
			this.gbPurchase.Controls.Add(this.lsbProduct);
			this.gbPurchase.Controls.Add(this.scbProduct);
			this.gbPurchase.Controls.Add(this.label6);
			this.gbPurchase.Controls.Add(this.cbCash);
			this.gbPurchase.Controls.Add(this.btnCancel);
			this.gbPurchase.Controls.Add(this.lblAddEdit);
			this.gbPurchase.Controls.Add(this.btnAddEdit);
			this.gbPurchase.Controls.Add(this.label5);
			this.gbPurchase.Controls.Add(this.txbSum);
			this.gbPurchase.Controls.Add(this.label4);
			this.gbPurchase.Controls.Add(this.txbVolume);
			this.gbPurchase.Controls.Add(this.label3);
			this.gbPurchase.Location = new System.Drawing.Point(16, 146);
			this.gbPurchase.Name = "gbPurchase";
			this.gbPurchase.Size = new System.Drawing.Size(1240, 486);
			this.gbPurchase.TabIndex = 5;
			this.gbPurchase.TabStop = false;
			this.gbPurchase.Text = "Оформить покупку";
			this.gbPurchase.Visible = false;
			// 
			// dtpDate
			// 
			this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpDate.Location = new System.Drawing.Point(623, 198);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(212, 24);
			this.dtpDate.TabIndex = 1;
			// 
			// cbOneMore
			// 
			this.cbOneMore.AutoSize = true;
			this.cbOneMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbOneMore.Location = new System.Drawing.Point(818, 334);
			this.cbOneMore.Name = "cbOneMore";
			this.cbOneMore.Size = new System.Drawing.Size(178, 20);
			this.cbOneMore.TabIndex = 14;
			this.cbOneMore.Text = "Добавить еще товар";
			this.cbOneMore.UseVisualStyleBackColor = true;
			// 
			// lsbProduct
			// 
			this.lsbProduct.FormattingEnabled = true;
			this.lsbProduct.ItemHeight = 16;
			this.lsbProduct.Location = new System.Drawing.Point(61, 223);
			this.lsbProduct.Name = "lsbProduct";
			this.lsbProduct.Size = new System.Drawing.Size(556, 148);
			this.lsbProduct.TabIndex = 6;
			this.lsbProduct.Visible = false;
			this.lsbProduct.Click += new System.EventHandler(this.lsbProduct_Click);
			this.lsbProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbProduct_KeyUp);
			// 
			// scbProduct
			// 
			this.scbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scbProduct.FormattingEnabled = true;
			this.scbProduct.Location = new System.Drawing.Point(61, 196);
			this.scbProduct.Name = "scbProduct";
			this.scbProduct.Size = new System.Drawing.Size(556, 26);
			this.scbProduct.TabIndex = 0;
			this.scbProduct.SelectedIndexChanged += new System.EventHandler(this.scbProduct_SelectedIndexChanged);
			this.scbProduct.SelectionChangeCommitted += new System.EventHandler(this.scbProduct_SelectionChangeCommitted);
			this.scbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scbProduct_KeyDown);
			this.scbProduct.Leave += new System.EventHandler(this.scbProduct_Leave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(838, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Название счета";
			// 
			// cbCash
			// 
			this.cbCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbCash.FormattingEnabled = true;
			this.cbCash.Location = new System.Drawing.Point(841, 196);
			this.cbCash.Name = "cbCash";
			this.cbCash.Size = new System.Drawing.Size(220, 26);
			this.cbCash.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(818, 268);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(147, 34);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblAddEdit
			// 
			this.lblAddEdit.AutoSize = true;
			this.lblAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddEdit.Location = new System.Drawing.Point(48, 49);
			this.lblAddEdit.Name = "lblAddEdit";
			this.lblAddEdit.Size = new System.Drawing.Size(383, 42);
			this.lblAddEdit.TabIndex = 8;
			this.lblAddEdit.Text = "Оформляем покупку";
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddEdit.Location = new System.Drawing.Point(1014, 268);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(147, 34);
			this.btnAddEdit.TabIndex = 5;
			this.btnAddEdit.Text = "Добавить";
			this.btnAddEdit.UseVisualStyleBackColor = true;
			this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(1148, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Сумма";
			// 
			// txbSum
			// 
			this.txbSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbSum.Location = new System.Drawing.Point(1151, 198);
			this.txbSum.Name = "txbSum";
			this.txbSum.Size = new System.Drawing.Size(81, 24);
			this.txbSum.TabIndex = 4;
			this.txbSum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbSum_KeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1064, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Кол-во";
			// 
			// txbVolume
			// 
			this.txbVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txbVolume.Location = new System.Drawing.Point(1067, 198);
			this.txbVolume.Name = "txbVolume";
			this.txbVolume.Size = new System.Drawing.Size(78, 24);
			this.txbVolume.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Наименование продукции";
			// 
			// txbProductFilter
			// 
			this.txbProductFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txbProductFilter.Location = new System.Drawing.Point(902, 23);
			this.txbProductFilter.Name = "txbProductFilter";
			this.txbProductFilter.Size = new System.Drawing.Size(330, 22);
			this.txbProductFilter.TabIndex = 9;
			this.txbProductFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbProductFilter_KeyUp);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(816, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Продукция";
			// 
			// cbCashFilter
			// 
			this.cbCashFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCashFilter.FormattingEnabled = true;
			this.cbCashFilter.Location = new System.Drawing.Point(610, 21);
			this.cbCashFilter.Name = "cbCashFilter";
			this.cbCashFilter.Size = new System.Drawing.Size(200, 24);
			this.cbCashFilter.TabIndex = 7;
			this.cbCashFilter.SelectedIndexChanged += new System.EventHandler(this.cbCashFilter_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(564, 25);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Счет";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Начиная с";
			// 
			// dtpEnd
			// 
			this.dtpEnd.Location = new System.Drawing.Point(344, 23);
			this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.Size = new System.Drawing.Size(211, 22);
			this.dtpEnd.TabIndex = 2;
			this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
			// 
			// dtpStart
			// 
			this.dtpStart.Location = new System.Drawing.Point(101, 23);
			this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.Size = new System.Drawing.Size(205, 22);
			this.dtpStart.TabIndex = 1;
			this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
			// 
			// lvPurchase
			// 
			this.lvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvPurchase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Date,
            this.Cash,
            this.ProductName,
            this.volume,
            this.Sum});
			this.lvPurchase.ContextMenuStrip = this.contextMenuStrip1;
			this.lvPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvPurchase.FullRowSelect = true;
			this.lvPurchase.GridLines = true;
			this.lvPurchase.Location = new System.Drawing.Point(8, 53);
			this.lvPurchase.Margin = new System.Windows.Forms.Padding(4);
			this.lvPurchase.Name = "lvPurchase";
			this.lvPurchase.Size = new System.Drawing.Size(1224, 425);
			this.lvPurchase.TabIndex = 0;
			this.lvPurchase.UseCompatibleStateImageBehavior = false;
			this.lvPurchase.View = System.Windows.Forms.View.Details;
			// 
			// Number
			// 
			this.Number.Text = "Номер";
			// 
			// Date
			// 
			this.Date.Text = "Дата";
			this.Date.Width = 130;
			// 
			// Cash
			// 
			this.Cash.Text = "Счет";
			this.Cash.Width = 150;
			// 
			// ProductName
			// 
			this.ProductName.Text = "Продукция";
			this.ProductName.Width = 580;
			// 
			// volume
			// 
			this.volume.Text = "Объем";
			this.volume.Width = 120;
			// 
			// Sum
			// 
			this.Sum.Text = "Сумма";
			this.Sum.Width = 120;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.RemoveToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripMenuItem.Image")));
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.AddToolStripMenuItem.Text = "Добавить";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.EditToolStripMenuItem.Text = "Изменить";
			this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// RemoveToolStripMenuItem
			// 
			this.RemoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripMenuItem.Image")));
			this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
			this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.RemoveToolStripMenuItem.Text = "Удалить";
			this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(313, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "по";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1272, 663);
			this.Controls.Add(this.gbPurchase);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbCashPanel);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMain";
			this.Text = "HomeCash";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gbPurchase.ResumeLayout(false);
			this.gbPurchase.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripButton tsbAddPurchase;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox gbCashPanel;
		private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CashToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvPurchase;
		private System.Windows.Forms.ColumnHeader Number;
		private System.Windows.Forms.ColumnHeader ProductName;
		private System.Windows.Forms.ColumnHeader volume;
		private System.Windows.Forms.ColumnHeader Sum;
		private System.Windows.Forms.DateTimePicker dtpEnd;
		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ColumnHeader Cash;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbPurchase;
		private System.Windows.Forms.Button btnAddEdit;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txbSum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbVolume;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblAddEdit;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolStripMenuItem topupMenuToolStripMenuItem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbCash;
		private System.Windows.Forms.ToolStripButton tsbCash;
		private System.Windows.Forms.ToolStripButton tsbProduct;
		private System.Windows.Forms.ListBox lsbProduct;
		private System.Windows.Forms.ComboBox scbProduct;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSum;
		private System.Windows.Forms.CheckBox cbOneMore;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbTopUp;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txbProductFilter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cbCashFilter;
		private System.Windows.Forms.Label label7;
	}
}

