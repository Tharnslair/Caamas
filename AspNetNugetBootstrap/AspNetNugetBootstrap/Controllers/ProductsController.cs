using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AspNetNugetBootstrap.Models;

using Microsoft.Ajax.Utilities;

namespace AspNetNugetBootstrap.Controllers
{
    public class ProductsController : Controller
    {
        // stuff
        private readonly ApplicationDbContext _context;
        private readonly ICurrentUser _currentUser;
        //
        // GET: /Products/
        public ProductsController(ApplicationDbContext context, ICurrentUser currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }
        public ActionResult Index()
        {
            var models = _context.Products.Project().To<ProductViewModel>().ToArray();
            return View(models);
        }
	}
}