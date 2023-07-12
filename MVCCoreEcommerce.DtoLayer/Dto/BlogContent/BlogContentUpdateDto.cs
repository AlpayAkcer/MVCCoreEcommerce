﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.DtoLayer.Dto.BlogContent
{
    public class BlogContentUpdateDto
    {
        public int BlogContentID { get; set; }
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public bool IsStatus { get; set; }
    }
}