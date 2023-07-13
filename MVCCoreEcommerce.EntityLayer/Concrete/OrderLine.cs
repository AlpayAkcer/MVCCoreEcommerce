using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class OrderLine
    {
        [Key]
        public int OrderLineID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime OrderDate { get; set; }
        public int StatusID { get; set; }
        public Status Status { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Adres { get; set; }
        public string Semt { get; set; }
        public string Sehir { get; set; }
        public string PostaKodu { get; set; }
    }
}
