﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.Entities.StoreEntity
{
    public class Category
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Product Product { get; set; } 
    }
}
