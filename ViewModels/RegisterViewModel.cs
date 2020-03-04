﻿
using Code360NEWWEB.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action:"IsEmailInUse", controller:"Account")]
        [ValidEmailDomain(allowedDomain:  "Code360.com", 
            ErrorMessage = "Email domain must be Code360.com" )]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",
              ErrorMessage ="Password and confirmation do not match.")]
        public string ConfirmPassword { get; set; }


    }
}