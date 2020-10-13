using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace projectCourses.Areas.Admin.Models
{
    public class LoginAdmin
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
       [DataType(DataType.Password)]
       [Required]
        public string Passward { get; set; }
        public string message { get; set; }
    }
}