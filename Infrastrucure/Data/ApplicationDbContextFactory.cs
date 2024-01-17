using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ShawarmaHousePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseSqlServer("workstation id=aspnet-ShawarmaHousePortal.mssql.somee.com;packet size=4096;user id=mubarakxp_SQLLogin_1;pwd=rea618n187;data source=aspnet-ShawarmaHousePortal.mssql.somee.com;persist security info=False;initial catalog=aspnet-ShawarmaHousePortal");
           optionsBuilder.UseSqlServer("Server=DESKTOP-3L54SVH\\SQLEXPRESS;Database=aspnet-ShawarmaHousePortal;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
