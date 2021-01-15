using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TropicalServerApp.Models
{
    public class UserLogin
    {   
/*        [Required]*/
        public string UserID { get; set; }
/*        [Required]*/
        public string Password { get; set; }
/*        [Required]*/
        public string EmailID { get; set; }
    }
}