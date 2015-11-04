using System;
using System.Collections.Generic;

namespace SGM
{
	public class Menu
	{
		public string Name {get; private set;}
		public double Price {get; private set;}
		public int Stock {get; private set;}
		public List<Product> ProductList = new List<Product>();

		public Menu (string Name, double Price, List<Product> ProductList, int Stock)
		{
			this.Name = Name;
			this.Price = Price;
			this.Stock = Stock;
			this.ProductList.AddRange(ProductList);
		}

		public int setStock (int Stock)
		{
				this.Stock = Stock;

				return this.Stock;
		}

		public int decreaseStock (int DecreaseAmount)
		{
			this.Stock = this.Stock - DecreaseAmount;

			return this.Stock;
		}
	}
}
