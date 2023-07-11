using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class BlogContent
    {
        [Key]
        public int BlogContentID { get; set; }
        public int BlogCategoryID { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public bool IsStatus { get; set; }
    }
}
