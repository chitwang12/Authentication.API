﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_and_Authentication_WEB_API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]
     
        public string Password { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }


    }
}
