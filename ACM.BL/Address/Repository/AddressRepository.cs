using System.Collections.Generic;

namespace ACM.BL.Address.Repository
{
    public class AddressRepository
    {
        public Model.Address Retrieve(int AddressId)
        {
            if (1.Equals(AddressId))
                return new Model.Address(AddressId)
                {
                    AddressType = 1,
                    StreetLine1 = "Rua X",
                    StreetLine2 = "Número 111 Centro",
                    City = "São Francisco",
                    State = "São Paulo",
                    Country = "Brasil",
                    PostalCode = "15710000"
                };
            return new Model.Address();
        }

        public IEnumerable<Model.Address> RetrieveByCustomerId(int customerId) =>
            new List<Model.Address>()
            {
                new Model.Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Rua X",
                    StreetLine2 = "Número 111 Centro",
                    City = "São Francisco",
                    State = "São Paulo",
                    Country = "Brasil",
                    PostalCode = "15710000"
                },
                new Model.Address(2)
                {
                    AddressType = 2,
                    StreetLine1 = "Rua Y",
                    StreetLine2 = "Número 112 Centro",
                    City = "São Francisco",
                    State = "São Paulo",
                    Country = "Brasil",
                    PostalCode = "15710000"
                }

            };

        public bool Save()
        {

            return true;
        }
    }
}
