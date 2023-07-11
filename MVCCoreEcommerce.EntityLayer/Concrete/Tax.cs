using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Tax
    {
        [Key]
        public int TaxID { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public string Description { get; set; }
        public bool IsStatus { get; set; }

        List<Product> Products { get; set; }
    }
}
