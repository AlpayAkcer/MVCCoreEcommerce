﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    //Cart kullanımı için 
    public class Order
    {
        public Order()
        {
            Count = 1;
        }

        [Key]
        public int OrderID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
