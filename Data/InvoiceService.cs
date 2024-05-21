// Change invoiceID using static variable Count

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
            invoice.InvoiceID = Convert.ToString(++Invoice.Count);
            await _applicationDbContext.Invoices.AddAsync(invoice);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Get Invoice by InvoiceID
        public async Task<Invoice> GetInvoiceById(string id)
        {
            Invoice invoice = await _applicationDbContext.Invoices.FirstOrDefaultAsync(x => x.InvoiceID == id);
            return invoice;
        }

        // Get Invoice by Customer ID
        public async Task<List<Invoice>> GetInvoiceByCustomerID(string customerID)
        {
            List<Invoice> matchedInvoices = await _applicationDbContext.Invoices.Where(i => i.CustomerID == customerID).ToListAsync();
            return matchedInvoices;
        }
    }
}
