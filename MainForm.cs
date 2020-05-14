using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
	public partial class MainForm : Form
	{
		Inventory inventory = new Inventory();
		InHouse inHouse = new InHouse();
		Outsourced outsourced = new Outsourced();
		public MainForm()
		{
			InitializeComponent();
			inventory.SeedAllParts(inHouse, outsourced);
			PartsListView.View = View.Details;
			UpdateForm();
		}

		public void UpdateForm()
		{
			
			PartsListView.Items.Clear();
			for (int i = 0; i < inventory.allParts.Count; i++)
			{
				PartsListView.Items.Add
					(new ListViewItem(new string[] { inventory.allParts[i].PartId.ToString(), inventory.allParts[i].Name, inventory.allParts[i].InStock.ToString(), inventory.allParts[i].Price.ToString(), inventory.allParts[i].Min.ToString(), inventory.allParts[i].Max.ToString() }));
			}
			PartsListView.Items[0].Focused = true;
			PartsListView.Items[0].Selected = true;
		}

		private void PartsAddButton_Click(object sender, EventArgs e)
		{
			AddOrModifyPartForm addOrModifyPartForm = new AddOrModifyPartForm("Add",this, inventory, PartsListView, inHouse, outsourced);

			addOrModifyPartForm.Show();
			this.Hide();
		}

		private void PartsModifyButton_Click(object sender, EventArgs e)
		{

			if (inventory.LookupPart(int.Parse(PartsListView.SelectedItems[0].SubItems[0].Text)).GetType() == typeof(InHouse))
			{
				InHouse inPart = (InHouse)inventory.LookupPart(int.Parse(PartsListView.SelectedItems[0].SubItems[0].Text));
				new AddOrModifyPartForm("Modify", this, inventory, PartsListView, inPart, null).ShowDialog();
			}
			else
			{
				Outsourced outPart = (Outsourced)inventory.LookupPart(int.Parse(PartsListView.SelectedItems[0].SubItems[0].Text));
				new AddOrModifyPartForm("Modify", this, inventory, PartsListView, null, outPart).ShowDialog();
			}
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PartsDeleteButton_Click(object sender, EventArgs e)
		{
			if (PartsListView.Items.Count >= 2)
			{
				DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					inventory.DeletePart(inventory.allParts[int.Parse(PartsListView.SelectedItems[0].SubItems[0].Text)]);
				}
			}
			else
			{
				MessageBox.Show("Can not delete because it is the only item.", "Can not delete!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			UpdateForm();
		}

		private void PartsSearchButton_Click(object sender, EventArgs e)
		{
			int number;
			bool success = int.TryParse(PartsSearchTextBox.Text, out number);

			if (!string.IsNullOrEmpty(PartsSearchTextBox.Text) && number < inventory.allParts.Count && number >= 0 && success)
			{
				inventory.LookupPart(int.Parse(PartsSearchTextBox.Text));
				PartsListView.Items.Clear();
				PartsListView.Items.Add
					(new ListViewItem(new string[] { inventory.allParts[int.Parse(PartsSearchTextBox.Text)].PartId.ToString(), inventory.allParts[int.Parse(PartsSearchTextBox.Text)].Name, inventory.allParts[int.Parse(PartsSearchTextBox.Text)].InStock.ToString(), inventory.allParts[int.Parse(PartsSearchTextBox.Text)].Price.ToString(), inventory.allParts[int.Parse(PartsSearchTextBox.Text)].Min.ToString(), inventory.allParts[int.Parse(PartsSearchTextBox.Text)].Max.ToString() }));
			}

			else 
			{
				MessageBox.Show("The entered search criteria must be a be a valid part id.", "Not a valid part id!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void PartsSearchTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(PartsSearchTextBox.Text))
			{
				UpdateForm();
			}
		}
	}
}
