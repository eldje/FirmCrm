namespace FirmCrm.Database.Models
{
    class Customer
    {
        public Customer(string lastName, string firstName, Address address)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Address = address;
        }
        public int CustomerId { get; set; }
        public int CutomerNumber { get; set; }
        public int CustomerStatus { get; set; } = 1;
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ReductionRate { get; set; } = 0;
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
