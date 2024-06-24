using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp;
public class AppDbContext : DbContext {
    public DbSet<User> Users { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Product> Products { get; set; } 
    public DbSet<Request> Requests { get; set; }
    public DbSet<RequestLine> RequestLines { get; set; }
    public AppDbContext() { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder) ;
        {
            var connectionString = "server=localhost\\sqlexpress;" +
                "database=tqlprsdb;" +
               "trusted_connection = true;" +
               "trustServerCertificate=true;";


            optionsBuilder.UseSqlServer(connectionString);
        }
        
    }


}//End of Class
