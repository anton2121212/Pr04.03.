﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04._03
{
    abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public abstract void Info();

        public bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }
    }
}
