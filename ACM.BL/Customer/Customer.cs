
namespace ACM.BL.Customer
{
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public static int InstanceCount { get; set; }

        public bool Validate() =>
            !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
    }
}
