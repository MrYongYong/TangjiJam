using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TangjinJam.Infrastructure.Ef
{
    public class TangjinJamDbContext : DbContext
    {
        public TangjinJamDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
