namespace FirmCrm.Database.Models
{
    public class Address 
    {
        public Address(string street, int number, int postalCode, string city)
        {
            this.Street = street;
            this.Number = Number;
            this.PostalCode = PostalCode;
            this.City = City;
        }
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Bus { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public bool Newsletter { get; set; }
        public string Email { get; set; }
    }
}
