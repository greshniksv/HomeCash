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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.IncomingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.счетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.gbCashPanel = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEnd = new System.Windows.Forms.DateTimePicker();
			this.dtpStart = new System.Windows.Forms.DateTimePicker();
			this.lstPurchase = new System.Windows.Forms.ListView();
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1272, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.управлениеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1272, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// новыйToolStripMenuItem
			// 
			this.новыйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashToolStripMenuItem,
            this.IncomingToolStripMenuItem,
            this.purchaseToolStripMenuItem});
			this.новыйToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
			this.новыйToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.новыйToolStripMenuItem.Text = "Создать";
			// 
			// cashToolStripMenuItem
			// 
			this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
			this.cashToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.cashToolStripMenuItem.Text = "Счет";
			this.cashToolStripMenuItem.Click += new System.EventHandler(this.cashToolStripMenuItem_Click);
			// 
			// IncomingToolStripMenuItem
			// 
			this.IncomingToolStripMenuItem.Name = "IncomingToolStripMenuItem";
			this.IncomingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.IncomingToolStripMenuItem.Text = "Приход";
			// 
			// purchaseToolStripMenuItem
			// 
			this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
			this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.purchaseToolStripMenuItem.Text = "Покупку";
			// 
			// управлениеToolStripMenuItem
			// 
			this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счетToolStripMenuItem1,
            this.товарыToolStripMenuItem});
			this.управлениеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
			this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
			this.управлениеToolStripMenuItem.Text = "Управление";
			// 
			// счетToolStripMenuItem1
			// 
			this.счетToolStripMenuItem1.Name = "счетToolStripMenuItem1";
			this.счетToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.счетToolStripMenuItem1.Text = "Счет";
			// 
			// товарыToolStripMenuItem
			// 
			this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
			this.товарыToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.товарыToolStripMenuItem.Text = "Товары";
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
			this.statusStrip1.Location = new System.Drawing.Point(0, 641);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(1272, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
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
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpEnd);
			this.groupBox2.Controls.Add(this.dtpStart);
			this.groupBox2.Controls.Add(this.lstPurchase);
			this.groupBox2.Location = new System.Drawing.Point(16, 146);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(1240, 486);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Покупки";
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
			// lstPurchase
			// 
			this.lstPurchase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Number,
            this.Date,
            this.Cash,
            this.ProductName,
            this.volume,
            this.Sum});
			this.lstPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lstPurchase.FullRowSelect = true;
			this.lstPurchase.GridLines = true;
			this.lstPurchase.Location = new System.Drawing.Point(8, 53);
			this.lstPurchase.Margin = new System.Windows.Forms.Padding(4);
			this.lstPurchase.Name = "lstPurchase";
			this.lstPurchase.Size = new System.Drawing.Size(1224, 425);
			this.lstPurchase.TabIndex = 0;
			this.lstPurchase.UseCompatibleStateImageBehavior = false;
			this.lstPurchase.View = System.Windows.Forms.View.Details;
			// 
			// id
			// 
			this.id.Text = "id";
			this.id.Width = 0;
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
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1272, 663);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbCashPanel);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMain";
			this.Text = "HomeCash";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.GroupBox gbCashPanel;
		private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem IncomingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem счетToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lstPurchase;
		private System.Windows.Forms.ColumnHeader Number;
		private System.Windows.Forms.ColumnHeader ProductName;
		private System.Windows.Forms.ColumnHeader volume;
		private System.Windows.Forms.ColumnHeader Sum;
		private System.Windows.Forms.ColumnHeader id;
		private System.Windows.Forms.DateTimePicker dtpEnd;
		private System.Windows.Forms.DateTimePicker dtpStart;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ColumnHeader Cash;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

