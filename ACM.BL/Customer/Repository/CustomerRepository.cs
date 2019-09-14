
namespace ACM.BL.Customer.Repository
{
    public class CustomerRepository
    {
        public Customer.Model.Customer Retrieve(int customerId)
        {
            if (1.Equals(customerId))
                return new Customer.Model.Customer(customerId)
                {
                    EmailAddress = "luiz@sistemasbr.net",
                    FirstName = "Luiz Roberto",
                    LastName = "Reinoso"
                };
            return new Customer.Model.Customer(customerId);
        }
    }
}
