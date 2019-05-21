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
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "11 Dewy Meadow Road";
                address.StreetLine2 = "Salford";
                address.City = "Manchester";
                address.PostCode = "M6 6GT";
                address.Country = "United Kingdom";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "11 Dewy Meadow Road",
                StreetLine2 = "Salford",
                City = "Manchester",
                PostCode = "M6 6GT",
                Country = "United Kingdom"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "12 Eagle Drive",
                StreetLine2 = "Salford",
                City = "Manchester",
                PostCode = "M6 6EY",
                Country = "United Kingdom"
            };
            addressList.Add(address);

            return addressList;
        }


        public bool Save(Address address)
        {
            return true;
        }
    }
}