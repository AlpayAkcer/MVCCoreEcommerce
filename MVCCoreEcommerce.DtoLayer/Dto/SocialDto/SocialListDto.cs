using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.SocialDto
{
    public class SocialListDto
    {
        public int SocialID { get; set; }
        public string Name { get; set; }
        public string ClassIcon { get; set; }
        public string Url { get; set; }
        public bool IsStatus { get; set; }
    }
}
