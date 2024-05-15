// Change invoiceID using static variable Count


using MetaMonkeysBillingSystem.App.Models;
using MetaMonkeysStore.ServerApp.Context;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class InvoiceService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public InvoiceService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Add new invoice
        public async Task<bool> AddInvoice(Invoice invoice)
        {
            invoice.InvoiceID = ++Invoice.Count;
            await _applicationDbContext.Invoices.AddAsync(invoice);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Get Invoice by InvoiceID
        public async Task<Invoice> GetInvoiceById(int id)
        {
            Invoice invoice = await _applicationDbContext.Invoices.FirstOrDefaultAsync(x => x.InvoiceID == id);
            return invoice;
        }

        // Get Invoice by customer phone
    }
}
