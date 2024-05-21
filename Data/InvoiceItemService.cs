using MetaMonkeysStore.ServerApp.Context;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class InvoiceItemService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public InvoiceItemService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Add invoiceItem to InvoiceItem table
        public async Task<bool> AddInvoiceItem(InvoiceItem invoiceItem)
        {
            invoiceItem.InvoiceItemID = Convert.ToString(++InvoiceItem.Count);
            await _applicationDbContext.InvoiceItems.AddAsync(invoiceItem);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Get all items in an invoice by invoice Id
        public async Task<List<InvoiceItem>> GetInvoiceItemsById(string id)
        {
            List<InvoiceItem> invoiceItems = await _applicationDbContext.InvoiceItems.Where(item => item.InvoiceID == id).ToListAsync();
            return invoiceItems;
        }
    }
}
