﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ETradeContex : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
