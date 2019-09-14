using System.Collections.Generic;

namespace ACM.BL.Customer.Model
{
    public class Customer : EntityBase.EntityBase
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address.Model.Address>();
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public IList<Address.Model.Address> AddressList { get; set; }

        public static int InstanceCount { get; set; }

        public override bool Validate() =>
            !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);

        public override string ToString() => FullName;
    }
}
