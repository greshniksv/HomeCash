namespace HomeCash
{
	using System.Windows.Forms;

	partial class FrmListProduct
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.lvProduct = new System.Windows.Forms.ListView();
			this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gbAddEditProduct = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddEdit = new System.Windows.Forms.Button();
			this.lblAddEditHeader = new System.Windows.Forms.Label();
			this.txbProductName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.gbAddEditProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(2, 411);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(635, 2);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOk.Location = new System.Drawing.Point(540, 425);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(86, 23);
			this.btnOk.TabIndex = 5;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lvProduct
			// 
			this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name});
			this.lvProduct.ContextMenuStrip = this.contextMenuStrip1;
			this.lvProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lvProduct.FullRowSelect = true;
			this.lvProduct.GridLines = true;
			this.lvProduct.Location = new System.Drawing.Point(12, 12);
			this.lvProduct.Name = "lvProduct";
			this.lvProduct.Size = new System.Drawing.Size(614, 393);
			this.lvProduct.TabIndex = 7;
			this.lvProduct.UseCompatibleStateImageBehavior = false;
			this.lvProduct.View = System.Windows.Forms.View.Details;
			// 
			// Name
			// 
			this.Name.Text = "Название продукта";
			this.Name.Width = 580;
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
			this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
			this.AddToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.AddToolStripMenuItem.Text = "Добавить";
			this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
			// 
			// EditToolStripMenuItem
			// 
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			this.EditToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.EditToolStripMenuItem.Text = "Изменить";
			this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
			// 
			// RemoveToolStripMenuItem
			// 
			this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
			this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.RemoveToolStripMenuItem.Text = "Удалить";
			this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
			// 
			// gbAddEditProduct
			// 
			this.gbAddEditProduct.Controls.Add(this.btnCancel);
			this.gbAddEditProduct.Controls.Add(this.btnAddEdit);
			this.gbAddEditProduct.Controls.Add(this.lblAddEditHeader);
			this.gbAddEditProduct.Controls.Add(this.txbProductName);
			this.gbAddEditProduct.Controls.Add(this.label1);
			this.gbAddEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbAddEditProduct.Location = new System.Drawing.Point(12, 12);
			this.gbAddEditProduct.Name = "gbAddEditProduct";
			this.gbAddEditProduct.Size = new System.Drawing.Size(614, 393);
			this.gbAddEditProduct.TabIndex = 9;
			this.gbAddEditProduct.TabStop = false;
			this.gbAddEditProduct.Visible = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(349, 235);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(108, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAddEdit
			// 
			this.btnAddEdit.Location = new System.Drawing.Point(489, 235);
			this.btnAddEdit.Name = "btnAddEdit";
			this.btnAddEdit.Size = new System.Drawing.Size(106, 23);
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
			this.lblAddEditHeader.Size = new System.Drawing.Size(337, 42);
			this.lblAddEditHeader.TabIndex = 2;
			this.lblAddEditHeader.Text = "Добавить продукт";
			// 
			// txbProductName
			// 
			this.txbProductName.Location = new System.Drawing.Point(24, 143);
			this.txbProductName.Name = "txbProductName";
			this.txbProductName.Size = new System.Drawing.Size(571, 22);
			this.txbProductName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Наименование продукта";
			// 
			// FrmListProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 460);
			this.Controls.Add(this.gbAddEditProduct);
			this.Controls.Add(this.lvProduct);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnOk);
			this.Load += new System.EventHandler(this.FrmListProduct_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.gbAddEditProduct.ResumeLayout(false);
			this.gbAddEditProduct.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView lvProduct;
		private System.Windows.Forms.ColumnHeader Name;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
		private System.Windows.Forms.GroupBox gbAddEditProduct;
		private System.Windows.Forms.Label lblAddEditHeader;
		private System.Windows.Forms.TextBox txbProductName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddEdit;
		private System.Windows.Forms.Button btnCancel;
	}
}