﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

    }
}
