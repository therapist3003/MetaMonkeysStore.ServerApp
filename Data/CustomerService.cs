using MetaMonkeysStore.ServerApp.Context;
using Microsoft.EntityFrameworkCore;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // Add customer
        public async Task<bool> AddCustomer(Customer customer)
        {
            customer.CustomerID = Convert.ToString(++Customer.Count);
            await _applicationDbContext.Customers.AddAsync(customer);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        // Get customer by customer ID
        public async Task<Customer> GetCustomerById(string customerID)
        {
            Customer queriedCustomer = await _applicationDbContext.Customers.FirstOrDefaultAsync(x => x.CustomerID == customerID);
            return queriedCustomer;
        }


        // Get customer by phone no.
        public async Task<Customer> GetCustomerByPhone(string phoneNo)
        {
            Customer queriedCustomer = await _applicationDbContext.Customers.FirstOrDefaultAsync(x => x.Phone == phoneNo);
            return queriedCustomer;
        }
    }
}
