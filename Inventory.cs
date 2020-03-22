using System.ComponentModel;

namespace InventorySystem
{
	public class Inventory
	{
		public BindingList<Product> products = new BindingList<Product>();

		public BindingList<Part> allParts = new BindingList<Part>();

		public BindingList<Product> Products { get { return products; } set { products = value; } }
		public BindingList<Part> AllParts { get { return allParts; } set { allParts = value; } }
		
		public void AddProduct(Product product)
		{
			Products.Add(product);
		}

		public bool RemoveProduct(int id)
		{
			Products.Remove(Products[id]);
			return false;
		}

		public Product LookupProduct(int id)
		{
			return Products[id];
		}

		public void UpdateProduct(int id, Product product)
		{
			Products[id] = product;
		}

		public void AddPart(Part part)
		{
			AllParts.Add(part);
		}

		public bool DeletePart(Part part)
		{
			AllParts.Remove(part);
			return false;
		}

		public Part LookupPart(int id)
		{
			return AllParts[id];
		}

		public void UpdatePart(int id, Part part)
		{
			AllParts[id] = part;
		}

		public void SeedAllParts()
		{
			InHouse inHouse = new InHouse();
			Outsourced outsourced = new Outsourced();
			inHouse.PartId = 0;
			inHouse.Name = "stuff";
			inHouse.InStock = 5;
			inHouse.Price = 5.50M;
			inHouse.Min = 1;
			inHouse.Max = 5;
			inHouse.MachineId = 1;
			AddPart(inHouse);
		}
	}
}
