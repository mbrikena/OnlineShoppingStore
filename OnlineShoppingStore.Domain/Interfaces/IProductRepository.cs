using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;

namespace OnlineShoppingStore.Domain.Interfaces
{
	public interface IProductRepository
	{
	    IEnumerable<Product> Products { get; set; }

		void SaveProduct(Product product);
		Product DeleteProduct(int productId);
	}
}
