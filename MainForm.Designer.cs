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
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(1025, 591);
			this.Name = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button PartsAddButton;
		private System.Windows.Forms.Button PartsModifyButton;
		private System.Windows.Forms.Button PartsDeleteButton;
		private System.Windows.Forms.Button ProductsAddButton;
		private System.Windows.Forms.Button ProductsModifyButton;
		private System.Windows.Forms.Button ProductsDeleteButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button PartsSearchButton;
		private System.Windows.Forms.Button ProductsSearchButton;
		private System.Windows.Forms.TextBox PartsSearchTextBox;
		private System.Windows.Forms.TextBox ProductsSearchTextBox;
		private System.Windows.Forms.Label InventoryManagementLabel;
		private System.Windows.Forms.Label PartsLabel;
		private System.Windows.Forms.Label ProductsLabel;
		private System.Windows.Forms.ListView PartsListView;
		private System.Windows.Forms.ListView ProductsListView;
		private System.Windows.Forms.ColumnHeader PartIDHeader;
		private System.Windows.Forms.ColumnHeader PartNameHeader;
		private System.Windows.Forms.ColumnHeader PartInventoryHeader;
		private System.Windows.Forms.ColumnHeader PartPriceHeader;
		private System.Windows.Forms.ColumnHeader PartMinHeader;
		private System.Windows.Forms.ColumnHeader PartMaxHeader;
		private System.Windows.Forms.ColumnHeader ProductIdHeader;
		private System.Windows.Forms.ColumnHeader ProductNameHeader;
		private System.Windows.Forms.ColumnHeader ProductInventoryHeader;
		private System.Windows.Forms.ColumnHeader ProductPriceHeader;
		private System.Windows.Forms.ColumnHeader ProductMinHeader;
		private System.Windows.Forms.ColumnHeader ProductMaxHeader;
	}
}

