using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplicationTest.Models
{
    public class mvcUserModel
    {
        public int UsersID { get; set; }

        [Required(ErrorMessage ="This Field is Empty")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field is Empty")]
        public string Email { get; set; }

        public string Mobile { get; set; }

    }
}