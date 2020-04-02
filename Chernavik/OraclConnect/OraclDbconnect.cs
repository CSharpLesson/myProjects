
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chernavik
{
    public class OraclDbconnect: DbContext
    {
        public OraclDbconnect() 
        {
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (COMMUNITY = TCP)(PROTOCOL = TCP)(HOST = 192.168.45.84)(PORT = 1522)))(CONNECT_DATA = (SID = avast))); User Id = genesis; Password=genesis;Pooling=true");
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle("Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (COMMUNITY = TCP)(PROTOCOL = TCP)(HOST = 192.168.45.84)(PORT = 1522)))(CONNECT_DATA = (SID = avast))); User Id = genesis; Password=genesis;Pooling=true");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<AuthRoles> AuthModules { get; set; }
    }
}


