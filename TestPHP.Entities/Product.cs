﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPHP.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
    }
}
