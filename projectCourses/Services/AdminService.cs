using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectCourses.Data;
namespace projectCourses.Services
{
    public interface IAdmins
    {
        bool Login(string Email, string password);
        bool ChangePassword(string Email, string password);
        bool forgetpassword(string Email);

    }
    public class AdminService : IAdmins
    {

        public CoursesDBEntities1 context { get; set; }
        public AdminService()
        {
            context = new CoursesDBEntities1();
        }

        public bool ChangePassword(string Email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Login(string Email, string password)
        {
            return context.
                    Admins.Where(a => a.Email == Email && a.Password == password)
                    .Any();
        }

        public bool forgetpassword(string Email)
        {
            throw new NotImplementedException();
        }
    }

}