
using ACM.BL.Model;

namespace ACM.BL.Repositories
{
    public class CustomerRepository
    {
        public Customer.Customer Retrieve(int customerId)
        {
            if (1.Equals(customerId))
                return new Customer.Customer(customerId)
                {
                    EmailAddress = "luiz@sistemasbr.net",
                    FirstName = "Luiz Roberto",
                    LastName = "Reinoso"
                };
            return new Customer.Customer(customerId);
        }
    }
}
