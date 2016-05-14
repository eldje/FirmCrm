using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
