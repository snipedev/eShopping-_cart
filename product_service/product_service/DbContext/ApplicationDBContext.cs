using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using product_service.Models;


namespace product_service.DbContext
{
    public class ApplicationDBContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
