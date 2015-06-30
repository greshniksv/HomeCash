namespace HomeCash
{
	partial class FrmListTopUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListTopUp));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.lblAddEditHeader = new System.Windows.Forms.Label();
			this.txbObject = new System.Windows.Forms.TextBox();
			this.gbAddEdit = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbCashList = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvTopUp = new System.Windows.Forms.ListView();
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gbAddEdit.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(-5, 423);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(635, 2);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(533, 437);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(86, 23);
			this.btnOk.TabIndex = 7;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Location = new System.Drawing.Point(501, 259);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(94, 23);
			this.btnAddEdit.TabIndex = 3;
			this.btnAddEdit.Text = "button1";
			this.btnAddEdit.UseVisualStyleBackColor = true;
			this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
			// 
			// lblAddEditHeader
			// 
			this.lblAddEditHeader.AutoSize = true;
			this.lblAddEditHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddEditHeader.Location = new System.Drawing.Point(21, 29);
			this.lblAddEditHeader.Name = "lblAddEditHeader";
			this.lblAddEditHeader.Size = new System.Drawing.Size(294, 42);
			this.lblAddEditHeader.TabIndex = 2;
			this.lblAddEditHeader.Text = "Пополнить счет";
			// 
			// txbObject
			// 
			this.txbObject.Location = new System.Drawing.Point(24, 143);
			this.txbObject.Name = "txbObject";
			this.txbObject.Size = new System.Drawing.Size(571, 22);
			this.txbObject.TabIndex = 1;
			// 
			// gbAddEdit
			// 
			this.gbAddEdit.Controls.Add(this.btnCancel);
			this.gbAddEdit.Controls.Add(this.cbCashList);
			this.gbAddEdit.Controls.Add(this.btnAddEdit);
			this.gbAddEdit.Controls.Add(this.lblAddEditHeader);
			this.gbAddEdit.Controls.Add(this.txbObject);
			this.gbAddEdit.Controls.Add(this.label1);
			this.gbAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbAddEdit.Location = new System.Drawing.Point(12, 12);
			this.gbAddEdit.Name = "gbAddEdit";
			this.gbAddEdit.Size = new System.Drawing.Size(607, 393);
			this.gbAddEdit.TabIndex = 11;
			this.gbAddEdit.TabStop = false;
			this.gbAddEdit.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(377, 259);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbCashList
			// 
			this.cbCashList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCashList.FormattingEnabled = true;
			this.cbCashList.Location = new System.Drawing.Point(24, 200);
			this.cbCashList.Name = "cbCashList";
			this.cbCashList.Size = new System.Drawing.Size(571, 24);
			this.cbCashList.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма для внесения";
			// 
			// lvTopUp
			// 
			this.lvTopUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.Cash,
            this.sum});
			this.lvTopUp.ContextMenuStrip = this.contextMenuStrip1;
			this.lvTopUp.FullRowSelect = true;
			this.lvTopUp.GridLines = true;
			this.lvTopUp.Location = new System.Drawing.Point(12, 12);
			this.lvTopUp.Name = "lvTopUp";
			this.lvTopUp.Size = new System.Drawing.Size(607, 393);
			this.lvTopUp.TabIndex = 10;
			this.lvTopUp.UseCompatibleStateImageBehavior = false;
			this.lvTopUp.View = System.Windows.Forms.View.Details;
			// 
			// Date
			// 
			this.Date.Text = "Дата";
			this.Date.Width = 130;
			// 
			// Cash
			// 
			this.Cash.Text = "Название счета";
			this.Cash.Width = 300;
			// 
			// sum
			// 
			this.sum.Text = "Сумма";
			this.sum.Width = 140;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.RemoveToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
			// 
			// AddToolStripMenuItem
			// 
			this.AddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripMenuItem.Image")));
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.AddToolStripMenuItem.Text = "Добавить";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.EditToolStripMenuItem.Text = "Изменить";
			this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// RemoveToolStripMenuItem
			// 
			this.RemoveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripMenuItem.Image")));
			this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
			this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.RemoveToolStripMenuItem.Text = "Удалить";
			this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
			// 
			// FrmListTopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 472);
			this.Controls.Add(this.gbAddEdit);
			this.Controls.Add(this.lvTopUp);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmListTopUp";
			this.Text = "Поплнения";
			this.Load += new System.EventHandler(this.FrmListTopUp_Load);
			this.gbAddEdit.ResumeLayout(false);
			this.gbAddEdit.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnAddEdit;
		private System.Windows.Forms.Label lblAddEditHeader;
		private System.Windows.Forms.TextBox txbObject;
		private System.Windows.Forms.GroupBox gbAddEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvTopUp;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ComboBox cbCashList;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader Cash;
		private System.Windows.Forms.ColumnHeader sum;
		private System.Windows.Forms.Button btnCancel;
	}
}