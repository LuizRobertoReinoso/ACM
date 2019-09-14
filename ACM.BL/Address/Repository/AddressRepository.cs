
namespace ACM.BL.Address.Repository
{
    public class AddressRepository
    {
        public Model.Address Retrieve(int AddressId)
        {
            if(1.Equals(AddressId))
                return new Model.Address(AddressId)
                {
                    AddressType = 1,
                    StreetLine1 = "Rua X",
                    StreetLine2="Número 111 Centro",
                    City="São Francisco",
                    State="São Paulo",
                    Country="Brasil",
                    PostalCode="15710000"
                };
            return new Model.Address();
        }

        public bool Save()
        {

            return true;
        }
    }
}
