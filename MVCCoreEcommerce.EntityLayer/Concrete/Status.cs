﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.EntityLayer.Concrete
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string Name { get; set; }
        public bool IsStatus { get; set; }
    }
}
