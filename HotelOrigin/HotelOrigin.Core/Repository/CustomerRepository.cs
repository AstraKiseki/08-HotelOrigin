using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;

namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

//Create
        public static Customer Create()
        {
            Customer customer = new Customer();

            customers.Add(customer);

            return customer;
        }



        //Read
        public static Customer GetById(int id)
        {

            return customers.FirstOrDefault(c => c.Id == id);
            //            Customer foundCustomer = null;
            //
            //            for (int i = 0; i < customers.Count; i++)
            //           {
            //               if (customers.ElementAt(i).Id == id)
            //               {
            //                   foundCustomer = customers.ElementAt(i);
            //               }
            //           }
            //
            //            return foundCustomer;
        }

        public static ObservableCollection<Customer> GetAll()
        {
            return customers;
        }
        // Update
        public static void Update(Customer customer, string firstName, string lastName, string telephone, string EmailAddress)
        {
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.TelephoneNumber = telephone;
            customer.EmailAddress = EmailAddress;
        }

        // Delete

        public static void Delete(int id)
        {
            var customer = GetById(id);

            customers.Remove(customer);
        }
    }
}

