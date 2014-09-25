using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCM.BL
{
    public class CustomerRepository
    {
        private AddressRepository ar { get; set; }

        public CustomerRepository()
        {
            ar = new AddressRepository();
        }

        /// <summary>
        /// Retrieve one customer.
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            Customer customer = new Customer(customerId);
            customer.AddressList = ar.RetrieveByCustomerId(customerId).ToList();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "chorn@corsec.net";
                customer.FirstName = "Corran";
                customer.LastName = "Horn";
            }
            return customer;
        }

        /// <summary>
        /// Retrieves all customers.
        /// </summary>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all customers
            return new List<Customer>();
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

    }
}
