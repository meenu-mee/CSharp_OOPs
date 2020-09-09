using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository(); //collaborative relationship
        }
        private AddressRepository addressRepository { get; set; }

        //Retrieves one customer by Id
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.FirstName = "Daniel";
                customer.LastName = "Caesar";
                customer.EmailAddress = "daniel@gmail.com";
                customer.AddressList = addressRepository.RetrieveByCustId(customerId).ToList();
            }
            return customer;
        }

        //Saves the current Customer
        public bool Save(Customer customer)
        {
            var isSaved = true;
            return isSaved;
        }

    }
}
