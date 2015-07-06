namespace HomeCash
{
	partial class FrmMove
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMove));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.gbAddEdit = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbCashListFrom = new System.Windows.Forms.ComboBox();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.lblAddEditHeader = new System.Windows.Forms.Label();
			this.txbObject = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCashListTo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lvMove = new System.Windows.Forms.ListView();
			this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CashFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.sum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CashTo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.gbAddEdit.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(-2, 418);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1010, 4);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(907, 435);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(86, 25);
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// gbAddEdit
			// 
			this.gbAddEdit.Controls.Add(this.label3);
			this.gbAddEdit.Controls.Add(this.label2);
			this.gbAddEdit.Controls.Add(this.cbCashListTo);
			this.gbAddEdit.Controls.Add(this.btnCancel);
			this.gbAddEdit.Controls.Add(this.cbCashListFrom);
			this.gbAddEdit.Controls.Add(this.btnAddEdit);
			this.gbAddEdit.Controls.Add(this.lblAddEditHeader);
			this.gbAddEdit.Controls.Add(this.txbObject);
			this.gbAddEdit.Controls.Add(this.label1);
			this.gbAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbAddEdit.Location = new System.Drawing.Point(194, 439);
			this.gbAddEdit.Name = "gbAddEdit";
			this.gbAddEdit.Size = new System.Drawing.Size(607, 393);
			this.gbAddEdit.TabIndex = 12;
			this.gbAddEdit.TabStop = false;
			this.gbAddEdit.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(377, 296);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(104, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// cbCashListFrom
			// 
			this.cbCashListFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCashListFrom.FormattingEnabled = true;
			this.cbCashListFrom.Location = new System.Drawing.Point(24, 200);
			this.cbCashListFrom.Name = "cbCashListFrom";
			this.cbCashListFrom.Size = new System.Drawing.Size(571, 24);
			this.cbCashListFrom.TabIndex = 4;
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Location = new System.Drawing.Point(501, 296);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(94, 23);
			this.btnAddEdit.TabIndex = 3;
			this.btnAddEdit.Text = "button1";
			this.btnAddEdit.UseVisualStyleBackColor = true;
			// 
			// lblAddEditHeader
			// 
			this.lblAddEditHeader.AutoSize = true;
			this.lblAddEditHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddEditHeader.Location = new System.Drawing.Point(21, 29);
			this.lblAddEditHeader.Name = "lblAddEditHeader";
			this.lblAddEditHeader.Size = new System.Drawing.Size(269, 42);
			this.lblAddEditHeader.TabIndex = 2;
			this.lblAddEditHeader.Text = "Перемещение";
			// 
			// txbObject
			// 
			this.txbObject.Location = new System.Drawing.Point(24, 143);
			this.txbObject.Name = "txbObject";
			this.txbObject.Size = new System.Drawing.Size(571, 22);
			this.txbObject.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма";
			// 
			// cbCashListTo
			// 
			this.cbCashListTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCashListTo.FormattingEnabled = true;
			this.cbCashListTo.Location = new System.Drawing.Point(24, 256);
			this.cbCashListTo.Name = "cbCashListTo";
			this.cbCashListTo.Size = new System.Drawing.Size(571, 24);
			this.cbCashListTo.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 181);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Переместить сумму со счета";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 237);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "На счет";
			// 
			// lvMove
			// 
			this.lvMove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date,
            this.CashFrom,
            this.CashTo,
            this.sum});
			this.lvMove.FullRowSelect = true;
			this.lvMove.GridLines = true;
			this.lvMove.Location = new System.Drawing.Point(12, 12);
			this.lvMove.Name = "lvMove";
			this.lvMove.Size = new System.Drawing.Size(981, 393);
			this.lvMove.TabIndex = 13;
			this.lvMove.UseCompatibleStateImageBehavior = false;
			this.lvMove.View = System.Windows.Forms.View.Details;
			// 
			// Date
			// 
			this.Date.Text = "Дата";
			this.Date.Width = 130;
			// 
			// CashFrom
			// 
			this.CashFrom.Text = "Со счета    =>";
			this.CashFrom.Width = 330;
			// 
			// sum
			// 
			this.sum.Text = "Сумма";
			this.sum.Width = 140;
			// 
			// CashTo
			// 
			this.CashTo.Text = "На счет";
			this.CashTo.Width = 330;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.removeToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripMenuItem.Image")));
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.addToolStripMenuItem.Text = "Добавить";
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditToolStripMenuItem.Image")));
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.EditToolStripMenuItem.Text = "Изменить";
			// 
			// removeToolStripMenuItem1
			// 
			this.removeToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem1.Image")));
			this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
			this.removeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.removeToolStripMenuItem1.Text = "Удалить";
			// 
			// FrmMove
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 472);
			this.Controls.Add(this.lvMove);
			this.Controls.Add(this.gbAddEdit);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnOk);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMove";
			this.Text = "FrmMove";
			this.Load += new System.EventHandler(this.FrmMove_Load);
			this.gbAddEdit.ResumeLayout(false);
			this.gbAddEdit.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.GroupBox gbAddEdit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCashListTo;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbCashListFrom;
		private System.Windows.Forms.Button btnAddEdit;
		private System.Windows.Forms.Label lblAddEditHeader;
		private System.Windows.Forms.TextBox txbObject;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lvMove;
		private System.Windows.Forms.ColumnHeader Date;
		private System.Windows.Forms.ColumnHeader CashFrom;
		private System.Windows.Forms.ColumnHeader sum;
		private System.Windows.Forms.ColumnHeader CashTo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
	}
}