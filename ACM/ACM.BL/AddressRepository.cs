using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            var address = new Address();
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.City = "Gurgaon";
                address.State = "Haryana";
                address.Country = "India";
                address.PostalCode = "122001";
                address.StreetLine1 = "Line 1";
                address.StreetLine2 = "Line 2";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustId(int customerId) //returns a set pf addresses for a customer
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                City = "Gurgaon",
                State = "Haryana",
                Country = "India",
                PostalCode = "122001",
                StreetLine1 = "Line 1",
                StreetLine2 = "Line 2"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                City = "Sonipat",
                State = "Haryana",
                Country = "India",
                PostalCode = "122002",
                StreetLine1 = "Line 1/2"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var isSaved = true;
            return isSaved;
        }

    }
}
