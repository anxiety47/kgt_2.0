using System;
using System.ComponentModel.DataAnnotations;

namespace KGT.Data.DataTransferObjects.Account
{
    public class LoginModel
    {
        [Display(Name = "Login")]
        public string Username { get; set; }
        [Display(Name = "Hasło")]
        public string Password { get; set; }
    }
}
