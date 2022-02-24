using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Models.Views
{
    public class LoginUser
    {
        [Display(Name="Username")]
        public string UserName { get; set; }
        [Display(Name ="Password")]
        public string Password { get; set; }
        [Display(Name = "User Mail Id")]
        public string UserMailId { get; set; }
    }
}
