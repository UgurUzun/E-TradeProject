using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_TradeProject.MvcWebUI.SelectModels
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Display(Name = "Ürün Adı")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Marka")]
        public string TradeMark { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Tutar")]
        [Required]
        public double Price { get; set; }
        [Display(Name = "Resim")]
        public string Image { get; set; }
        [Display(Name = "Stok Adedi")]
        public int Stock { get; set; }
        public int? CategoryId { get; set; }

    }
}