using MetaMonkeysBillingSystem.App.Models;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysStore.ServerApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Item> Items { get; set; }

    }
}
