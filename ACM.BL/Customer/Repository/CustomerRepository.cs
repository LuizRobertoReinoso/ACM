
using System.Linq;
using ACM.BL.Address.Repository;

namespace ACM.BL.Customer.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        
        private AddressRepository addressRepository { get; set; }

        public Customer.Model.Customer Retrieve(int customerId)
        {
            if (1.Equals(customerId))
                return new Customer.Model.Customer(customerId)
                {
                    EmailAddress = "luiz@sistemasbr.net",
                    FirstName = "Luiz Roberto",
                    LastName = "Reinoso",
                    AddressList=addressRepository.RetrieveByCustomerId(customerId).ToList()
                };
            return new Customer.Model.Customer(customerId);
        }

        public bool Save(Model.Customer customer)
        {
            if (!customer.HasChanges) return true;

            if (!customer.IsValid) return false;
            if (customer.IsNew)
            {
                //Insert
            }
            else
            {
                //Update
            }

            return true;
        }
    }
}
