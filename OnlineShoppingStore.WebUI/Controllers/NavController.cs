﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Domain.Interfaces;

namespace OnlineShoppingStore.WebUI.Controllers
{
	public class NavController : Controller
	{
	   private IProductRepository repository;

		public NavController(IProductRepository repo)
		{
			repository = repo;
		}

	   public PartialViewResult Menu()
		{
			IEnumerable<string> categories = repository.Products
											 .Select(x => x.Category)
											 .Distinct()
											 .OrderBy(x => x);
			return PartialView(categories);
		}
	}
}