using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Social
    {
        [Key]
        public int SocialID { get; set; }
        public string Name { get; set; }
        public string ClassIcon { get; set; }
        public string Url { get; set; }
        public bool IsStatus { get; set; }
    }
}
