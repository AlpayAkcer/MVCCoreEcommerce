using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.ProductDto
{
    public class ProductListDto
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public int TaxID { get; set; }
        public string TaxName { get; set; }
        public string Name { get; set; }
        public string StockCode { get; set; }
        public string BarcodeNumber { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public decimal SalePrice { get; set; }
        public decimal ListPrice { get; set; }
        public int Stock { get; set; }
    }
}
