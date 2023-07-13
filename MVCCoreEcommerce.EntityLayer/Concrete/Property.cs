using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Property
    {
        public int PropertyId { get; set; }

        public string Attribute { get; set; }
        public string Value { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
