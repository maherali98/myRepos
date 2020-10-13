using projectCourses.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectCourses.Services
{
    public interface IAdmin
    {
        bool Login(string Email, string password);
        bool ChangePassword(string Email, string password);
        bool forgetpassword(string Email);

    }
    public class Admin : IAdmin
    {

        public CoursesDBEntities1 context { get; set; }
        public Admin()
        {
            context = new CoursesDBEntities1();
        } 

        public bool ChangePassword(string Email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Login(string Email, string password)
        {
             return  context.
                     Admins.Where(a => a.Email == Email && a.Password == password)
                     .Any();
        }

        public bool forgetpassword(string Email)
        {
            throw new NotImplementedException();
        }
    }
}