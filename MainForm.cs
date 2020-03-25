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
		public MainForm()
		{
			
			InitializeComponent();
			inventory.SeedAllParts();
			PartsListView.View = View.Details;
			UpdateForm();
			//for (int i = 0; i < inventory.allParts.Count; i++)
			//{
			//	PartsListView.Items.Add
			//		(new ListViewItem(new string[] { inventory.allParts[i].PartId.ToString(), inventory.allParts[i].Name, inventory.allParts[i].InStock.ToString(), inventory.allParts[i].Price.ToString(), inventory.allParts[i].Min.ToString(), inventory.allParts[i].Max.ToString() }));
			//}
			//PartsListView.Items[0].Focused = true;
			//PartsListView.Items[0].Selected = true;
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
			AddOrModifyPartForm addOrModifyPartForm = new AddOrModifyPartForm("Add",this, inventory, PartsListView);

			addOrModifyPartForm.Show();
			this.Hide();
		}

		private void PartsModifyButton_Click(object sender, EventArgs e)
		{
			AddOrModifyPartForm addOrModifyPartForm = new AddOrModifyPartForm("Modify", this, inventory, PartsListView);
			addOrModifyPartForm.Show();
			this.Hide();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PartsDeleteButton_Click(object sender, EventArgs e)
		{
			inventory.DeletePart(PartsListView.SelectedItems[0].);
		}
	}
}
