using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.SettingDto
{
    public class SettingUpdateDto
    {
        public int SettingID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string GoogleMap { get; set; }
        public string LogUrl { get; set; }
        public bool IsStatus { get; set; }
    }
}
