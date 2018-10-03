using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Domain.Interfaces;

namespace OnlineShoppingStore.Domain.Services
{
	public class FormsAuthenticationProvider : IAuthentication
	{
		private readonly StoreContext context = new StoreContext();

		public bool Authenticate(string username, string password)
		{
			var result = context.Users
				.FirstOrDefault(u => u.UserId == username 
				&& u.Password == password);

			if (result == null)
			    return false;
			return true;
			
		}

		public bool Logout()
		{
			return true;
		}
	}
}
