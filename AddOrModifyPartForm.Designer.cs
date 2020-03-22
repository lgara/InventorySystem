namespace InventorySystem
{
	partial class AddOrModifyPartForm
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
			this.AddPartLabel = new System.Windows.Forms.Label();
			this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
			this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
			this.AddPartIdLabel = new System.Windows.Forms.Label();
			this.AddPartNameLabel = new System.Windows.Forms.Label();
			this.AddPartInventoryLabel = new System.Windows.Forms.Label();
			this.AddPartPriceLabel = new System.Windows.Forms.Label();
			this.AddPartMaxLabel = new System.Windows.Forms.Label();
			this.AddPartMinLabel = new System.Windows.Forms.Label();
			this.AddPartMachineOrCompanyLabel = new System.Windows.Forms.Label();
			this.AddPartIdTextBox = new System.Windows.Forms.TextBox();
			this.AddPartNameTextBox = new System.Windows.Forms.TextBox();
			this.AddPartInventoryTextBox = new System.Windows.Forms.TextBox();
			this.AddPartPriceTextBox = new System.Windows.Forms.TextBox();
			this.AddPartMaxTextBox = new System.Windows.Forms.TextBox();
			this.AddPartMinTextBox = new System.Windows.Forms.TextBox();
			this.AddPartMachineOrCompanyTextBox = new System.Windows.Forms.TextBox();
			this.AddPartSaveButton = new System.Windows.Forms.Button();
			this.AddPartCancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddPartLabel
			// 
			this.AddPartLabel.AutoSize = true;
			this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddPartLabel.Location = new System.Drawing.Point(13, 13);
			this.AddPartLabel.Name = "AddPartLabel";
			this.AddPartLabel.Size = new System.Drawing.Size(72, 18);
			this.AddPartLabel.TabIndex = 0;
			this.AddPartLabel.Text = "Add Part";
			// 
			// InHouseRadioButton
			// 
			this.InHouseRadioButton.AutoSize = true;
			this.InHouseRadioButton.Checked = true;
			this.InHouseRadioButton.Location = new System.Drawing.Point(183, 12);
			this.InHouseRadioButton.Name = "InHouseRadioButton";
			this.InHouseRadioButton.Size = new System.Drawing.Size(68, 17);
			this.InHouseRadioButton.TabIndex = 1;
			this.InHouseRadioButton.TabStop = true;
			this.InHouseRadioButton.Text = "In-House";
			this.InHouseRadioButton.UseVisualStyleBackColor = true;
			this.InHouseRadioButton.CheckedChanged += new System.EventHandler(this.InHouseRadioButton_CheckedChanged);
			// 
			// OutsourcedRadioButton
			// 
			this.OutsourcedRadioButton.AutoSize = true;
			this.OutsourcedRadioButton.Location = new System.Drawing.Point(285, 12);
			this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
			this.OutsourcedRadioButton.Size = new System.Drawing.Size(80, 17);
			this.OutsourcedRadioButton.TabIndex = 2;
			this.OutsourcedRadioButton.Text = "Outsourced";
			this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
			this.OutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
			// 
			// AddPartIdLabel
			// 
			this.AddPartIdLabel.AutoSize = true;
			this.AddPartIdLabel.Location = new System.Drawing.Point(199, 92);
			this.AddPartIdLabel.Name = "AddPartIdLabel";
			this.AddPartIdLabel.Size = new System.Drawing.Size(16, 13);
			this.AddPartIdLabel.TabIndex = 3;
			this.AddPartIdLabel.Text = "Id";
			// 
			// AddPartNameLabel
			// 
			this.AddPartNameLabel.AutoSize = true;
			this.AddPartNameLabel.Location = new System.Drawing.Point(180, 118);
			this.AddPartNameLabel.Name = "AddPartNameLabel";
			this.AddPartNameLabel.Size = new System.Drawing.Size(35, 13);
			this.AddPartNameLabel.TabIndex = 4;
			this.AddPartNameLabel.Text = "Name";
			// 
			// AddPartInventoryLabel
			// 
			this.AddPartInventoryLabel.AutoSize = true;
			this.AddPartInventoryLabel.BackColor = System.Drawing.SystemColors.Control;
			this.AddPartInventoryLabel.Location = new System.Drawing.Point(164, 144);
			this.AddPartInventoryLabel.Name = "AddPartInventoryLabel";
			this.AddPartInventoryLabel.Size = new System.Drawing.Size(51, 13);
			this.AddPartInventoryLabel.TabIndex = 5;
			this.AddPartInventoryLabel.Text = "Inventory";
			// 
			// AddPartPriceLabel
			// 
			this.AddPartPriceLabel.AutoSize = true;
			this.AddPartPriceLabel.Location = new System.Drawing.Point(158, 170);
			this.AddPartPriceLabel.Name = "AddPartPriceLabel";
			this.AddPartPriceLabel.Size = new System.Drawing.Size(57, 13);
			this.AddPartPriceLabel.TabIndex = 6;
			this.AddPartPriceLabel.Text = "Price/Cost";
			// 
			// AddPartMaxLabel
			// 
			this.AddPartMaxLabel.AutoSize = true;
			this.AddPartMaxLabel.Location = new System.Drawing.Point(188, 196);
			this.AddPartMaxLabel.Name = "AddPartMaxLabel";
			this.AddPartMaxLabel.Size = new System.Drawing.Size(27, 13);
			this.AddPartMaxLabel.TabIndex = 7;
			this.AddPartMaxLabel.Text = "Max";
			// 
			// AddPartMinLabel
			// 
			this.AddPartMinLabel.AutoSize = true;
			this.AddPartMinLabel.Location = new System.Drawing.Point(298, 196);
			this.AddPartMinLabel.Name = "AddPartMinLabel";
			this.AddPartMinLabel.Size = new System.Drawing.Size(24, 13);
			this.AddPartMinLabel.TabIndex = 8;
			this.AddPartMinLabel.Text = "Min";
			// 
			// AddPartMachineOrCompanyLabel
			// 
			this.AddPartMachineOrCompanyLabel.AutoSize = true;
			this.AddPartMachineOrCompanyLabel.Location = new System.Drawing.Point(133, 222);
			this.AddPartMachineOrCompanyLabel.Name = "AddPartMachineOrCompanyLabel";
			this.AddPartMachineOrCompanyLabel.Size = new System.Drawing.Size(60, 13);
			this.AddPartMachineOrCompanyLabel.TabIndex = 9;
			this.AddPartMachineOrCompanyLabel.Text = "Machine Id";
			// 
			// AddPartIdTextBox
			// 
			this.AddPartIdTextBox.Location = new System.Drawing.Point(240, 92);
			this.AddPartIdTextBox.Name = "AddPartIdTextBox";
			this.AddPartIdTextBox.ReadOnly = true;
			this.AddPartIdTextBox.Size = new System.Drawing.Size(100, 20);
			this.AddPartIdTextBox.TabIndex = 10;
			// 
			// AddPartNameTextBox
			// 
			this.AddPartNameTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartNameTextBox.Location = new System.Drawing.Point(240, 118);
			this.AddPartNameTextBox.Name = "AddPartNameTextBox";
			this.AddPartNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.AddPartNameTextBox.TabIndex = 11;
			this.AddPartNameTextBox.TextChanged += new System.EventHandler(this.AddPartNameTextBox_TextChanged);
			// 
			// AddPartInventoryTextBox
			// 
			this.AddPartInventoryTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartInventoryTextBox.Location = new System.Drawing.Point(240, 144);
			this.AddPartInventoryTextBox.Name = "AddPartInventoryTextBox";
			this.AddPartInventoryTextBox.Size = new System.Drawing.Size(100, 20);
			this.AddPartInventoryTextBox.TabIndex = 12;
			this.AddPartInventoryTextBox.TextChanged += new System.EventHandler(this.AddPartInventoryTextBox_TextChanged);
			// 
			// AddPartPriceTextBox
			// 
			this.AddPartPriceTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartPriceTextBox.Location = new System.Drawing.Point(240, 170);
			this.AddPartPriceTextBox.Name = "AddPartPriceTextBox";
			this.AddPartPriceTextBox.Size = new System.Drawing.Size(100, 20);
			this.AddPartPriceTextBox.TabIndex = 13;
			this.AddPartPriceTextBox.TextChanged += new System.EventHandler(this.AddPartPriceTextBox_TextChanged);
			// 
			// AddPartMaxTextBox
			// 
			this.AddPartMaxTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartMaxTextBox.Location = new System.Drawing.Point(240, 196);
			this.AddPartMaxTextBox.Name = "AddPartMaxTextBox";
			this.AddPartMaxTextBox.Size = new System.Drawing.Size(47, 20);
			this.AddPartMaxTextBox.TabIndex = 14;
			this.AddPartMaxTextBox.TextChanged += new System.EventHandler(this.AddPartMaxTextBox_TextChanged);
			// 
			// AddPartMinTextBox
			// 
			this.AddPartMinTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartMinTextBox.Location = new System.Drawing.Point(339, 196);
			this.AddPartMinTextBox.Name = "AddPartMinTextBox";
			this.AddPartMinTextBox.Size = new System.Drawing.Size(47, 20);
			this.AddPartMinTextBox.TabIndex = 15;
			this.AddPartMinTextBox.TextChanged += new System.EventHandler(this.AddPartMinTextBox_TextChanged);
			// 
			// AddPartMachineOrCompanyTextBox
			// 
			this.AddPartMachineOrCompanyTextBox.BackColor = System.Drawing.Color.Red;
			this.AddPartMachineOrCompanyTextBox.Location = new System.Drawing.Point(240, 222);
			this.AddPartMachineOrCompanyTextBox.Name = "AddPartMachineOrCompanyTextBox";
			this.AddPartMachineOrCompanyTextBox.Size = new System.Drawing.Size(100, 20);
			this.AddPartMachineOrCompanyTextBox.TabIndex = 16;
			this.AddPartMachineOrCompanyTextBox.TextChanged += new System.EventHandler(this.AddPartMachineOrCompanyTextBox_TextChanged);
			// 
			// AddPartSaveButton
			// 
			this.AddPartSaveButton.Enabled = false;
			this.AddPartSaveButton.Location = new System.Drawing.Point(227, 283);
			this.AddPartSaveButton.Name = "AddPartSaveButton";
			this.AddPartSaveButton.Size = new System.Drawing.Size(75, 23);
			this.AddPartSaveButton.TabIndex = 17;
			this.AddPartSaveButton.Text = "Save";
			this.AddPartSaveButton.UseVisualStyleBackColor = true;
			this.AddPartSaveButton.Click += new System.EventHandler(this.AddPartSaveButton_Click);
			// 
			// AddPartCancelButton
			// 
			this.AddPartCancelButton.Location = new System.Drawing.Point(311, 283);
			this.AddPartCancelButton.Name = "AddPartCancelButton";
			this.AddPartCancelButton.Size = new System.Drawing.Size(75, 23);
			this.AddPartCancelButton.TabIndex = 18;
			this.AddPartCancelButton.Text = "Cancel";
			this.AddPartCancelButton.UseVisualStyleBackColor = true;
			this.AddPartCancelButton.Click += new System.EventHandler(this.AddPartCancelButton_Click);
			// 
			// AddOrModifyPartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 450);
			this.Controls.Add(this.AddPartCancelButton);
			this.Controls.Add(this.AddPartSaveButton);
			this.Controls.Add(this.AddPartMachineOrCompanyTextBox);
			this.Controls.Add(this.AddPartMinTextBox);
			this.Controls.Add(this.AddPartMaxTextBox);
			this.Controls.Add(this.AddPartPriceTextBox);
			this.Controls.Add(this.AddPartInventoryTextBox);
			this.Controls.Add(this.AddPartNameTextBox);
			this.Controls.Add(this.AddPartIdTextBox);
			this.Controls.Add(this.AddPartMachineOrCompanyLabel);
			this.Controls.Add(this.AddPartMinLabel);
			this.Controls.Add(this.AddPartMaxLabel);
			this.Controls.Add(this.AddPartPriceLabel);
			this.Controls.Add(this.AddPartInventoryLabel);
			this.Controls.Add(this.AddPartNameLabel);
			this.Controls.Add(this.AddPartIdLabel);
			this.Controls.Add(this.OutsourcedRadioButton);
			this.Controls.Add(this.InHouseRadioButton);
			this.Controls.Add(this.AddPartLabel);
			this.MaximumSize = new System.Drawing.Size(496, 489);
			this.MinimumSize = new System.Drawing.Size(496, 489);
			this.Name = "AddOrModifyPartForm";
			this.Text = "Add Part";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AddPartLabel;
		private System.Windows.Forms.RadioButton InHouseRadioButton;
		private System.Windows.Forms.RadioButton OutsourcedRadioButton;
		private System.Windows.Forms.Label AddPartIdLabel;
		private System.Windows.Forms.Label AddPartNameLabel;
		private System.Windows.Forms.Label AddPartInventoryLabel;
		private System.Windows.Forms.Label AddPartPriceLabel;
		private System.Windows.Forms.Label AddPartMaxLabel;
		private System.Windows.Forms.Label AddPartMinLabel;
		private System.Windows.Forms.Label AddPartMachineOrCompanyLabel;
		private System.Windows.Forms.TextBox AddPartIdTextBox;
		private System.Windows.Forms.TextBox AddPartNameTextBox;
		private System.Windows.Forms.TextBox AddPartInventoryTextBox;
		private System.Windows.Forms.TextBox AddPartPriceTextBox;
		private System.Windows.Forms.TextBox AddPartMaxTextBox;
		private System.Windows.Forms.TextBox AddPartMinTextBox;
		private System.Windows.Forms.TextBox AddPartMachineOrCompanyTextBox;
		private System.Windows.Forms.Button AddPartSaveButton;
		private System.Windows.Forms.Button AddPartCancelButton;
	}
}