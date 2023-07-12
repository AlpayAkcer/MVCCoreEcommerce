using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.StatusDto
{
    public class StatusListDto
    {
        public int StatusID { get; set; }
        public string Name { get; set; }
        public bool IsStatus { get; set; }
    }
}
