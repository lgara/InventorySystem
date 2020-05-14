namespace InventorySystem
{
	partial class MainForm
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
			this.PartsSearchButton = new System.Windows.Forms.Button();
			this.ProductsSearchButton = new System.Windows.Forms.Button();
			this.PartsAddButton = new System.Windows.Forms.Button();
			this.PartsModifyButton = new System.Windows.Forms.Button();
			this.PartsDeleteButton = new System.Windows.Forms.Button();
			this.ProductsAddButton = new System.Windows.Forms.Button();
			this.ProductsModifyButton = new System.Windows.Forms.Button();
			this.ProductsDeleteButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PartsSearchTextBox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.PartsListView = new System.Windows.Forms.ListView();
			this.PartsIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PartsNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PartsInventoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PartsPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PartsMinHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PartsMaxHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsListView = new System.Windows.Forms.ListView();
			this.ProductsIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsInventoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsPriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsMinHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductsMaxHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// PartsSearchButton
			// 
			this.PartsSearchButton.Location = new System.Drawing.Point(372, 60);
			this.PartsSearchButton.Name = "PartsSearchButton";
			this.PartsSearchButton.Size = new System.Drawing.Size(75, 23);
			this.PartsSearchButton.TabIndex = 0;
			this.PartsSearchButton.Text = "Search";
			this.PartsSearchButton.UseVisualStyleBackColor = true;
			this.PartsSearchButton.Click += new System.EventHandler(this.PartsSearchButton_Click);
			// 
			// ProductsSearchButton
			// 
			this.ProductsSearchButton.Location = new System.Drawing.Point(982, 58);
			this.ProductsSearchButton.Name = "ProductsSearchButton";
			this.ProductsSearchButton.Size = new System.Drawing.Size(75, 23);
			this.ProductsSearchButton.TabIndex = 1;
			this.ProductsSearchButton.Text = "Search";
			this.ProductsSearchButton.UseVisualStyleBackColor = true;
			// 
			// PartsAddButton
			// 
			this.PartsAddButton.Location = new System.Drawing.Point(353, 357);
			this.PartsAddButton.Name = "PartsAddButton";
			this.PartsAddButton.Size = new System.Drawing.Size(75, 23);
			this.PartsAddButton.TabIndex = 2;
			this.PartsAddButton.Text = "Add";
			this.PartsAddButton.UseVisualStyleBackColor = true;
			this.PartsAddButton.Click += new System.EventHandler(this.PartsAddButton_Click);
			// 
			// PartsModifyButton
			// 
			this.PartsModifyButton.Location = new System.Drawing.Point(434, 357);
			this.PartsModifyButton.Name = "PartsModifyButton";
			this.PartsModifyButton.Size = new System.Drawing.Size(75, 23);
			this.PartsModifyButton.TabIndex = 3;
			this.PartsModifyButton.TabStop = false;
			this.PartsModifyButton.Text = "Modify";
			this.PartsModifyButton.UseVisualStyleBackColor = true;
			this.PartsModifyButton.Click += new System.EventHandler(this.PartsModifyButton_Click);
			// 
			// PartsDeleteButton
			// 
			this.PartsDeleteButton.Location = new System.Drawing.Point(515, 357);
			this.PartsDeleteButton.Name = "PartsDeleteButton";
			this.PartsDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.PartsDeleteButton.TabIndex = 4;
			this.PartsDeleteButton.Text = "Delete";
			this.PartsDeleteButton.UseVisualStyleBackColor = true;
			this.PartsDeleteButton.Click += new System.EventHandler(this.PartsDeleteButton_Click);
			// 
			// ProductsAddButton
			// 
			this.ProductsAddButton.Location = new System.Drawing.Point(963, 357);
			this.ProductsAddButton.Name = "ProductsAddButton";
			this.ProductsAddButton.Size = new System.Drawing.Size(75, 23);
			this.ProductsAddButton.TabIndex = 5;
			this.ProductsAddButton.Text = "Add";
			this.ProductsAddButton.UseVisualStyleBackColor = true;
			// 
			// ProductsModifyButton
			// 
			this.ProductsModifyButton.Location = new System.Drawing.Point(1044, 357);
			this.ProductsModifyButton.Name = "ProductsModifyButton";
			this.ProductsModifyButton.Size = new System.Drawing.Size(75, 23);
			this.ProductsModifyButton.TabIndex = 6;
			this.ProductsModifyButton.Text = "Modify";
			this.ProductsModifyButton.UseVisualStyleBackColor = true;
			// 
			// ProductsDeleteButton
			// 
			this.ProductsDeleteButton.Location = new System.Drawing.Point(1125, 357);
			this.ProductsDeleteButton.Name = "ProductsDeleteButton";
			this.ProductsDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.ProductsDeleteButton.TabIndex = 7;
			this.ProductsDeleteButton.Text = "Delete";
			this.ProductsDeleteButton.UseVisualStyleBackColor = true;
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(1125, 433);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 8;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Inventory Management System";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Parts";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(622, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Products";
			// 
			// PartsSearchTextBox
			// 
			this.PartsSearchTextBox.Location = new System.Drawing.Point(453, 62);
			this.PartsSearchTextBox.Name = "PartsSearchTextBox";
			this.PartsSearchTextBox.Size = new System.Drawing.Size(137, 20);
			this.PartsSearchTextBox.TabIndex = 14;
			this.PartsSearchTextBox.TextChanged += new System.EventHandler(this.PartsSearchTextBox_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(1063, 61);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(137, 20);
			this.textBox2.TabIndex = 15;
			// 
			// PartsListView
			// 
			this.PartsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PartsIdHeader,
            this.PartsNameHeader,
            this.PartsInventoryHeader,
            this.PartsPriceHeader,
            this.PartsMinHeader,
            this.PartsMaxHeader});
			this.PartsListView.FullRowSelect = true;
			this.PartsListView.GridLines = true;
			this.PartsListView.HideSelection = false;
			this.PartsListView.Location = new System.Drawing.Point(15, 87);
			this.PartsListView.MaximumSize = new System.Drawing.Size(575, 264);
			this.PartsListView.MinimumSize = new System.Drawing.Size(575, 264);
			this.PartsListView.Name = "PartsListView";
			this.PartsListView.Size = new System.Drawing.Size(575, 264);
			this.PartsListView.TabIndex = 16;
			this.PartsListView.UseCompatibleStateImageBehavior = false;
			// 
			// PartsIdHeader
			// 
			this.PartsIdHeader.Text = "Part ID";
			// 
			// PartsNameHeader
			// 
			this.PartsNameHeader.Text = "Name";
			this.PartsNameHeader.Width = 250;
			// 
			// PartsInventoryHeader
			// 
			this.PartsInventoryHeader.Text = "Inventory";
			// 
			// PartsPriceHeader
			// 
			this.PartsPriceHeader.Text = "Price";
			this.PartsPriceHeader.Width = 80;
			// 
			// PartsMinHeader
			// 
			this.PartsMinHeader.Text = "Min";
			// 
			// PartsMaxHeader
			// 
			this.PartsMaxHeader.Text = "Max";
			// 
			// ProductsListView
			// 
			this.ProductsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductsIdHeader,
            this.ProductsNameHeader,
            this.ProductsInventoryHeader,
            this.ProductsPriceHeader,
            this.ProductsMinHeader,
            this.ProductsMaxHeader});
			this.ProductsListView.FullRowSelect = true;
			this.ProductsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ProductsListView.HideSelection = false;
			this.ProductsListView.Location = new System.Drawing.Point(625, 87);
			this.ProductsListView.MaximumSize = new System.Drawing.Size(575, 264);
			this.ProductsListView.MinimumSize = new System.Drawing.Size(575, 264);
			this.ProductsListView.Name = "ProductsListView";
			this.ProductsListView.Size = new System.Drawing.Size(575, 264);
			this.ProductsListView.TabIndex = 17;
			this.ProductsListView.UseCompatibleStateImageBehavior = false;
			// 
			// ProductsIdHeader
			// 
			this.ProductsIdHeader.Text = "Product ID";
			// 
			// ProductsNameHeader
			// 
			this.ProductsNameHeader.Text = "Name";
			this.ProductsNameHeader.Width = 250;
			// 
			// ProductsPriceHeader
			// 
			this.ProductsPriceHeader.Text = "Price";
			this.ProductsPriceHeader.Width = 80;
			// 
			// ProductsMinHeader
			// 
			this.ProductsMinHeader.Text = "Min";
			// 
			// ProductsMaxHeader
			// 
			this.ProductsMaxHeader.Text = "Max";
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(1219, 470);
			this.Controls.Add(this.ProductsListView);
			this.Controls.Add(this.PartsListView);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.PartsSearchTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.ProductsDeleteButton);
			this.Controls.Add(this.ProductsModifyButton);
			this.Controls.Add(this.ProductsAddButton);
			this.Controls.Add(this.PartsDeleteButton);
			this.Controls.Add(this.PartsModifyButton);
			this.Controls.Add(this.PartsAddButton);
			this.Controls.Add(this.ProductsSearchButton);
			this.Controls.Add(this.PartsSearchButton);
			this.MaximumSize = new System.Drawing.Size(1235, 509);
			this.MinimumSize = new System.Drawing.Size(1235, 509);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		//private System.Windows.Forms.Button PartsAddButton;
		//private System.Windows.Forms.Button PartsModifyButton;
		//private System.Windows.Forms.Button PartsDeleteButton;
		//private System.Windows.Forms.Button ProductsAddButton;
		//private System.Windows.Forms.Button ProductsModifyButton;
		//private System.Windows.Forms.Button ProductsDeleteButton;
		//private System.Windows.Forms.Button ExitButton;
		//private System.Windows.Forms.Button PartsSearchButton;
		//private System.Windows.Forms.Button ProductsSearchButton;
		//private System.Windows.Forms.TextBox PartsSearchTextBox;
		//private System.Windows.Forms.TextBox ProductsSearchTextBox;
		//private System.Windows.Forms.Label InventoryManagementLabel;
		//private System.Windows.Forms.Label PartsLabel;
		//private System.Windows.Forms.Label ProductsLabel;
		//private System.Windows.Forms.ListView PartsListView;
		//private System.Windows.Forms.ListView ProductsListView;
		//private System.Windows.Forms.ColumnHeader PartIDHeader;
		//private System.Windows.Forms.ColumnHeader PartNameHeader;
		//private System.Windows.Forms.ColumnHeader PartInventoryHeader;
		//private System.Windows.Forms.ColumnHeader PartPriceHeader;
		//private System.Windows.Forms.ColumnHeader PartMinHeader;
		//private System.Windows.Forms.ColumnHeader PartMaxHeader;
		//private System.Windows.Forms.ColumnHeader ProductIdHeader;
		//private System.Windows.Forms.ColumnHeader ProductNameHeader;
		//private System.Windows.Forms.ColumnHeader ProductInventoryHeader;
		//private System.Windows.Forms.ColumnHeader ProductPriceHeader;
		//private System.Windows.Forms.ColumnHeader ProductMinHeader;
		//private System.Windows.Forms.ColumnHeader ProductMaxHeader;
		private System.Windows.Forms.Button PartsSearchButton;
		private System.Windows.Forms.Button ProductsSearchButton;
		private System.Windows.Forms.Button PartsAddButton;
		private System.Windows.Forms.Button PartsModifyButton;
		private System.Windows.Forms.Button PartsDeleteButton;
		private System.Windows.Forms.Button ProductsAddButton;
		private System.Windows.Forms.Button ProductsModifyButton;
		private System.Windows.Forms.Button ProductsDeleteButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PartsSearchTextBox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListView PartsListView;
		private System.Windows.Forms.ListView ProductsListView;
		private System.Windows.Forms.ColumnHeader PartsIdHeader;
		private System.Windows.Forms.ColumnHeader PartsNameHeader;
		private System.Windows.Forms.ColumnHeader PartsInventoryHeader;
		private System.Windows.Forms.ColumnHeader PartsPriceHeader;
		private System.Windows.Forms.ColumnHeader PartsMinHeader;
		private System.Windows.Forms.ColumnHeader PartsMaxHeader;
		private System.Windows.Forms.ColumnHeader ProductsIdHeader;
		private System.Windows.Forms.ColumnHeader ProductsNameHeader;
		private System.Windows.Forms.ColumnHeader ProductsInventoryHeader;
		private System.Windows.Forms.ColumnHeader ProductsPriceHeader;
		private System.Windows.Forms.ColumnHeader ProductsMinHeader;
		private System.Windows.Forms.ColumnHeader ProductsMaxHeader;
	}
}

