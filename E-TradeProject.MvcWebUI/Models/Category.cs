using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_TradeProject.MvcWebUI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        //*************************************************
        public List<Product> Products { get; set; }
    }
}