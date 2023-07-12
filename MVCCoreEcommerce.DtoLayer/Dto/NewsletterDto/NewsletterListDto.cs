using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.NewsletterDto
{
    public class NewsletterListDto
    {
        public int NewsletterID { get; set; }
        public string Email { get; set; }
        public bool IsStatus { get; set; }
    }
}
