namespace HomeCash
{
	using System.Windows.Forms;

	partial class FrmListCash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListCash));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lvCash = new System.Windows.Forms.ListView();
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnOk = new System.Windows.Forms.Button();
			this.gbAddEdit = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.lblAddEditHeader = new System.Windows.Forms.Label();
			this.txbObjectName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.gbAddEdit.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(-96, 401);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(847, 2);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// lvCash
			// 
			this.lvCash.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Cash});
			this.lvCash.ContextMenuStrip = this.contextMenuStrip1;
			this.lvCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvCash.FullRowSelect = true;
			this.lvCash.GridLines = true;
			this.lvCash.Location = new System.Drawing.Point(16, 15);
			this.lvCash.Margin = new System.Windows.Forms.Padding(4);
			this.lvCash.Name = "lvCash";
			this.lvCash.Size = new System.Drawing.Size(658, 369);
			this.lvCash.TabIndex = 5;
			this.lvCash.UseCompatibleStateImageBehavior = false;
			this.lvCash.View = System.Windows.Forms.View.Details;
			// 
			// Name
			// 
			this.Name.Text = "Наименование";
			this.Name.Width = 400;
			// 
			// Cash
			// 
			this.Cash.Text = "Кол-во денег";
			this.Cash.Width = 150;
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
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(556, 420);
			this.btnOk.Margin = new System.Windows.Forms.Padding(4);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(121, 28);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Ок";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// gbAddEdit
			// 
			this.gbAddEdit.Controls.Add(this.btnCancel);
			this.gbAddEdit.Controls.Add(this.btnAddEdit);
			this.gbAddEdit.Controls.Add(this.lblAddEditHeader);
			this.gbAddEdit.Controls.Add(this.txbObjectName);
			this.gbAddEdit.Controls.Add(this.label1);
			this.gbAddEdit.Location = new System.Drawing.Point(16, 6);
			this.gbAddEdit.Margin = new System.Windows.Forms.Padding(4);
			this.gbAddEdit.Name = "gbAddEdit";
			this.gbAddEdit.Padding = new System.Windows.Forms.Padding(4);
			this.gbAddEdit.Size = new System.Drawing.Size(658, 378);
			this.gbAddEdit.TabIndex = 7;
			this.gbAddEdit.TabStop = false;
			this.gbAddEdit.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(420, 219);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 28);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Location = new System.Drawing.Point(547, 219);
			this.btnAddEdit.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(100, 28);
			this.btnAddEdit.TabIndex = 7;
			this.btnAddEdit.Text = "button1";
			this.btnAddEdit.UseVisualStyleBackColor = true;
			this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
			// 
			// lblAddEditHeader
			// 
			this.lblAddEditHeader.AutoSize = true;
			this.lblAddEditHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddEditHeader.Location = new System.Drawing.Point(34, 40);
			this.lblAddEditHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblAddEditHeader.Name = "lblAddEditHeader";
			this.lblAddEditHeader.Size = new System.Drawing.Size(274, 42);
			this.lblAddEditHeader.TabIndex = 6;
			this.lblAddEditHeader.Text = "Добавить счет";
			// 
			// txbObjectName
			// 
			this.txbObjectName.Location = new System.Drawing.Point(29, 160);
			this.txbObjectName.Margin = new System.Windows.Forms.Padding(4);
			this.txbObjectName.Name = "txbObjectName";
			this.txbObjectName.Size = new System.Drawing.Size(618, 22);
			this.txbObjectName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 137);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Наименование счета";
			// 
			// FrmListCash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 461);
			this.Controls.Add(this.gbAddEdit);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lvCash);
			this.Controls.Add(this.groupBox2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Text = "Счета";
			this.Load += new System.EventHandler(this.FrmListCash_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.gbAddEdit.ResumeLayout(false);
			this.gbAddEdit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ListView lvCash;
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ColumnHeader Cash;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
		private System.Windows.Forms.GroupBox gbAddEdit;
		private System.Windows.Forms.Button btnAddEdit;
		private System.Windows.Forms.Label lblAddEditHeader;
		private System.Windows.Forms.TextBox txbObjectName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancel;
	}
}