using InvoiceApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceApplication.Data;

class ApplicationContext: DbContContext
{

    public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

    public DbSet<Invoices> Invoices { get; set; }

}