using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_TradeProject.MvcWebUI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Marka")]
        public string TradeMark { get; set; }
        [Display(Name ="Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Tutar")]
        [Required]
        public double Price { get; set; }
        [Display(Name="Resim")]
        public string Image { get; set; }
        [Display(Name = "Stok Adedi")]        
        public int Stock { get; set; }
        [Display(Name = "Anasayfada Mı?")]
        public bool IsHome { get; set; }
        [Display(Name = "Onaylı Mı?")]
        public bool IsApproved { get; set; }

        //*************************************************
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]        
        public Category Category { get; set; }

    }
}