using Microsoft.EntityFrameworkCore;
using OraclBilanIshlash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclBilanIshlash.Db
{
    public class OracleDataContext:DbContext
    {
        public OracleDataContext(DbContextOptions<OracleDataContext> options) : base(options)
        {
        }
        public DbSet<AuthRoles> AuthRoles { get; set; }
    }
}
