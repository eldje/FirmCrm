namespace FirmCrm.Database.Models
{
    class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
