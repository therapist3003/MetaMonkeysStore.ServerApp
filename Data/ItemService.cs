using MetaMonkeysBillingSystem.App.Models;
using MetaMonkeysStore.ServerApp.Context;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class ItemService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ItemService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Add item to inventory
        public async Task<bool> AddItemToInventory(Item item)
        {
            // item.Id is not changed here, since it is a prefixed value in barcode sticker by MM_Store
            await _applicationDbContext.Items.AddAsync(item);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
