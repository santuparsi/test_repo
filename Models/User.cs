using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HandOnModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls Enter Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        public string Name { get; set; }
        [Range(18,40,ErrorMessage ="Age between 18 to 40")]
        public int Age { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Pls Enter Email")]
        [EmailAddress(ErrorMessage ="Invalid EmailId")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pls Enter Mobile")]
        [RegularExpression("[6-9][0-9]{9}",ErrorMessage ="Invlaid Mobile")]
        public string Mobile { get; set; }
        public string Country { get; set; }
        [Required(ErrorMessage = "Pls Enter Password")]
        [RegularExpression("[a-z0-9]{6,8}",ErrorMessage ="Password is 6 to 8 char long")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}