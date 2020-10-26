using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Woo.Models;
using Woo.ViewModels;

namespace Woo.Data
{
    public class WooContext : IdentityDbContext<ApplicationUser>
    {
        public WooContext (DbContextOptions<WooContext> options)
            : base(options)
        {
        }

        public DbSet<Woo.Models.Item> Item { get; set; }

        public DbSet<Woo.Models.Customer> Customer { get; set; }

        public DbSet<Woo.Models.Price> Price { get; set; }

        public DbSet<Woo.Models.Seller> Seller { get; set; }

        public DbSet<Woo.Models.User> User { get; set; }

        public DbSet<Woo.Models.Resp> Resp { get; set; }

        public DbSet<Woo.Models.UserResp> UserResp { get; set; }

        public DbSet<Woo.Models.InvoiceT> InvoiceT { get; set; }

        public DbSet<Woo.Models.InvoiceH> InvoiceH { get; set; }

        public DbSet<Woo.Models.Param> Param { get; set; }

        public DbSet<Woo.Models.Device> Device { get; set; }

        public DbSet<Woo.Models.Warehouse> Warehouse { get; set; }

        public DbSet<Woo.Models.Receive> Receive { get; set; }

        public DbSet<Woo.Models.ReportHead> ReportHead { get; set; }

        public DbSet<Woo.Models.ReportTail> ReportTail { get; set; }

        public DbSet<Woo.Models.OrderHead> OrderHead { get; set; }

        public DbSet<Woo.Models.OrderTail> OrderTail { get; set; }

        public DbSet<Woo.Models.Login> Login { get; set; }

        public DbSet<Woo.Models.Client> Client { get; set; }

        

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* try
            {

                /*modelBuilder.Entity<ReportHead>()
                    .HasMany(b => b.ReportTails)
                    .WithOne(p => p.reportHead)
                    .OnDelete(DeleteBehavior.NoAction);

                

                modelBuilder.Entity<ReportHead>()
                     .HasMany<ReportTail>(g => g.ReportTails);


            }

            catch(Exception e)
            {
                string s = e.Message;
            }
            
            }*/


    }
}
