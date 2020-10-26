using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Woo.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "User")]
        public string user { get; set; }
        [Display(Name = "Password")]
        public string password { get; set; }
        [Display(Name = "NewPassword")]
        public string NewPassword { get; set; }
        [Display(Name = "OldPassword")]
        public string OldPassword { get; set; }

    }
}
