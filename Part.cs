﻿namespace InventorySystem
{
	public abstract class Part
	{
		public int PartId { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int InStock { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }
	}
}
