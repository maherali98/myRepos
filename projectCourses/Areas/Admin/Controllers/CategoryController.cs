using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projectCourses.Models;
using projectCourses.Services;

namespace projectCourses.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private readonly categoryServices categoryservices;

        public CategoryController()
        {
            categoryservices = new categoryServices();
        }
        
        // GET: Admin/Category
        public ActionResult Index()
        {
            var catergory = categoryservices.ReadAll();
            var categoryList = new List<categoryModel>();
            foreach (var item in catergory)
            {
                categoryList.Add(new categoryModel
                {
                    Id = item.ID,
                    Name=item.Name

                });
               

            }

            return View(categoryList);
        }
    }
}