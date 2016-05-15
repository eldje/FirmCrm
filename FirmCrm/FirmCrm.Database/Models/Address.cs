using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirmCrm.Database.Models
{
    public class Address 
    {
        public Address(string street, int number, int postalCode, string city)
        {
            this.Street = street;
            this.Number = number;
            this.PostalCode = postalCode;
            this.City = city;
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
