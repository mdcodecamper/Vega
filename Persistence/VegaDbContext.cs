﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Models;

namespace Vega.Persistence
{
    public class VegaDbContext:DbContext
    {

        public VegaDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Features> Features { get; set; }
    }
}