using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.TaxDto
{
    public class TaxUpdateDto
    {
        public int TaxID { get; set; }
        public string Name { get; set; }
        public decimal TaxRate { get; set; }
        public string Description { get; set; }
        public bool IsStatus { get; set; }
    }
}
