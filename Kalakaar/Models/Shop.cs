using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalakaar.Models
{
    public class Shop
    {
        [Key]
        public int ProductId { get; set; }
        public string ShopType { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Avail { get; set; }
        public string Discription { get; set; }
        public string Image1Url { get; set; }
        public string Image2Url { get; set; }
        public string ImgBanner { get; set; }
        public string Brand { get; set; }
        public int qty { get; set; }
    }
}
