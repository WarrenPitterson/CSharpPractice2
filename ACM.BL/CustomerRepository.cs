using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
   public  class CustomerRepository
    {
        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        private AddressRepository AddressRepository { get; set; }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "Warrenpittersondev@gmail.com";
                customer.FirstName = "Warren";
                customer.LastName = "Pitterson";
                customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
