using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public int TaxID { get; set; }
        public Tax Tax { get; set; }
        public string Name { get; set; }
        public string StockCode { get; set; }
        public string BarcodeNumber { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsMainSpecial { get; set; }
        public decimal SalePrice { get; set; }
        public decimal ListPrice { get; set; }
        public int Stock { get; set; }
        public bool IsStatus { get; set; }

        public List<Property> Properties { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
