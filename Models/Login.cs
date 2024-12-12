﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HandOnModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }
    }
}