#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CLPP.Praas.WebApi;

namespace CLPP.Praas.WebApi.Data
{
    public class CLPPPraasWebApiContext : DbContext
    {
        public CLPPPraasWebApiContext (DbContextOptions<CLPPPraasWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<CLPP.Praas.WebApi.Coupon> Coupon { get; set; }

        public DbSet<CLPP.Praas.WebApi.Promotion> Promotion { get; set; }
    }
}
