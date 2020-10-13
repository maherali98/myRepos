using projectCourses.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectCourses.Services
{
    public interface IcategoryServices
    {
        List<Category> ReadAll();
    }
    public class categoryServices : IcategoryServices
    {
        private readonly CoursesDBEntities1 db;
        public categoryServices()
        {
            db = new CoursesDBEntities1();
        }

        public List<Category> ReadAll()
        {
            return db.Categories.ToList();
        }
    }
}