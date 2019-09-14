using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_TradeProject.MvcWebUI.Models
{
    public class Register
    {        
        [DisplayName("Ad")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Soyad")]
        [Required]
        public string Surname { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("E-Posta")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DisplayName("Parola")]
        [Required]
        public string Password { get; set; }

        [DisplayName("Parola Tekrar")]
        [Compare("Password", ErrorMessage = "Girdiğiniz Şifreler Uyuşmamaktadır.")]
        [Required]
        public string RePassword { get; set; }
    }
}