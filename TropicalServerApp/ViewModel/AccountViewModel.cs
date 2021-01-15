using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TropicalServerApp.Models;
using System.ComponentModel.DataAnnotations;

namespace TropicalServerApp.ViewModel
{
    public class AccountViewModel
    {
        public UserLogin account { get; set; }

        /*[Display(Name = "Remember Me?")]*/
        public bool remember { get; set; }
    }
}