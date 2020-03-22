using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventorySystem
{
	public partial class AddOrModifyPartForm : Form
	{
		MainForm mainForm;
		Inventory inventory;
		ListView partsListView;
		InHouse inHouse = new InHouse();
		Outsourced outsourced = new Outsourced();
		string addOrModify = "";
		public AddOrModifyPartForm(string buttonPressed, MainForm form, Inventory inv, ListView ListView)
		{
			inventory = inv;

			mainForm = form;

			partsListView = ListView;

			InitializeComponent();

			AddPartLabel.Text = buttonPressed + " Part";

			addOrModify = buttonPressed;

			Text = buttonPressed + " Part";

			if (buttonPressed == "Modify")
			{
				AddPartIdTextBox.Text = partsListView.SelectedItems[0].SubItems[0].Text;
				AddPartNameTextBox.Text = partsListView.SelectedItems[0].SubItems[1].Text;
				AddPartInventoryTextBox.Text = partsListView.SelectedItems[0].SubItems[2].Text;
				AddPartPriceTextBox.Text = partsListView.SelectedItems[0].SubItems[3].Text;
				AddPartMaxTextBox.Text = partsListView.SelectedItems[0].SubItems[5].Text;
				AddPartMinTextBox.Text = partsListView.SelectedItems[0].SubItems[4].Text;
				AddPartMachineOrCompanyTextBox.Text = inHouse.MachineId.ToString();
			}
		}

		private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (InHouseRadioButton.Checked)
			{
				AddPartMachineOrCompanyLabel.Text = "Machine Id";
			}
		}

		private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (OutsourcedRadioButton.Checked)
			{
				AddPartMachineOrCompanyLabel.Text = "Company Name";
			}
		}

		private void AddPartCancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AddPartNameTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartNameTextBox.Text.Length == 0)
			{
				AddPartNameTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartNameTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void AddPartInventoryTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartInventoryTextBox.Text.Length == 0)
			{
				AddPartInventoryTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartInventoryTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void AddPartPriceTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartPriceTextBox.Text.Length == 0)
			{
				AddPartPriceTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartPriceTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void AddPartMaxTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartMaxTextBox.Text.Length == 0)
			{
				AddPartMaxTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartMaxTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void AddPartMinTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartMinTextBox.Text.Length == 0)
			{
				AddPartMinTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartMinTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void AddPartMachineOrCompanyTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AddPartMachineOrCompanyTextBox.Text.Length == 0)
			{
				AddPartMachineOrCompanyTextBox.BackColor = Color.Red;
			}
			else
			{
				AddPartMachineOrCompanyTextBox.BackColor = Color.White;
			}

			ValidateTextBoxes();
		}

		private void ValidateTextBoxes()
		{
			if (!string.IsNullOrWhiteSpace(AddPartNameTextBox.Text) && !string.IsNullOrWhiteSpace(AddPartInventoryTextBox.Text) && !string.IsNullOrWhiteSpace(AddPartPriceTextBox.Text)
				&& !string.IsNullOrWhiteSpace(AddPartMaxTextBox.Text) && !string.IsNullOrWhiteSpace(AddPartMinTextBox.Text) && !string.IsNullOrWhiteSpace(AddPartMachineOrCompanyTextBox.Text))
			{
				AddPartSaveButton.Enabled = true;
			}
			else
			{
				AddPartSaveButton.Enabled = false;
			}
		}
		
		private void AddPartSaveButton_Click(object sender, EventArgs e)
		{
			if (addOrModify == "Add")
			{
				AddPartIdTextBox.Text = inventory.AllParts.Count.ToString();
				if (InHouseRadioButton.Checked)
				{					
					inHouse.PartId = int.Parse(AddPartIdTextBox.Text);
					inHouse.Name = AddPartNameTextBox.Text;
					inHouse.Price = decimal.Parse(AddPartPriceTextBox.Text);
					inHouse.InStock = int.Parse(AddPartInventoryTextBox.Text);
					inHouse.Min = int.Parse(AddPartMinTextBox.Text);
					inHouse.Max = int.Parse(AddPartMaxTextBox.Text);
					inHouse.MachineId = int.Parse(AddPartMachineOrCompanyTextBox.Text);
					inventory.AddPart(inHouse);
				}
				else if (OutsourcedRadioButton.Checked)
				{
					outsourced.PartId = int.Parse(AddPartIdTextBox.Text);
					outsourced.Name = AddPartNameTextBox.Text;
					outsourced.Price = decimal.Parse(AddPartPriceTextBox.Text);
					outsourced.InStock = int.Parse(AddPartInventoryTextBox.Text);
					outsourced.Min = int.Parse(AddPartMinTextBox.Text);
					outsourced.Max = int.Parse(AddPartMaxTextBox.Text);
					outsourced.CompanyName = AddPartMachineOrCompanyTextBox.Text;
					inventory.AddPart(outsourced);
				}
			}
		
			mainForm.UpdateForm();
			this.Close();
		}
	}
}
