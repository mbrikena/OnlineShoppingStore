using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Domain.Interfaces;

namespace OnlineShoppingStore.Domain.Services
{
	public class ProductRepository : IProductRepository
	{
		private readonly StoreContext context = new StoreContext();

		public IEnumerable<Product> Products
		{
			get { return context.Products; }
			set { }
		}

		public void SaveProduct(Product product)
		{
			if (product.ProductId ==0)
			{
				context.Products.Add(product);
			}
			else
			{
				Product dbEntry = context.Products.Find(product.ProductId);
				if(dbEntry != null)
				{
					dbEntry.Name = product.Name;
					dbEntry.Description = product.Description;
					dbEntry.Price = product.Price;
					dbEntry.Category = product.Category;
				}
			}
			context.SaveChanges();
		}

		public Product DeleteProduct(int productId)
		{
			Product dbEntry = context.Products.Find(productId);
			if (dbEntry != null)
			{
				context.Products.Remove(dbEntry);
				context.SaveChanges();
			}

			return dbEntry;
		}
	}
}
