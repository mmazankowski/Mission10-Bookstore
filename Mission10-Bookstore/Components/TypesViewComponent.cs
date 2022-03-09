using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission10_Bookstore.Models;

namespace Mission10_Bookstore.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private iBookstoreRepository repo { get; set; }

        public TypesViewComponent(iBookstoreRepository temp)
        {
            repo = temp; 
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(types); 
        }
    }
}
