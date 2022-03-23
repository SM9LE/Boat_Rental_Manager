using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boat_Rental.Manager
{
    public class CustomerManager : DataManager
    {
        public Customer AddACustomer(Customer customer)
        {
            Context.Customers.Add(customer);
            if (Context.SaveChanges() > 0)
                return customer;
            return null;
        }
        public bool DeleteACustomer(Customer customer)
        {
            if (customer != null)
            {
                Context.Customers.Remove(customer);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteACustomer(int id)
        {
            Customer customer = FindACustomerByID(id);
            if (customer == null)
                return false;
            return DeleteACustomer(customer);
        }
        public bool EditACustomer(Customer customer)
        {
            Context.Entry(customer).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }
        public Customer FindACustomerByID(int id)
        {
            return Context.Customers.Find(id);
        }

        public Customer FindACustomerByMail(string mail)
            => Context.Customers.FirstOrDefault(customer => customer.MailCustomer == mail);

        public List<Customer> GetCustomers()
    => Context.Customers.ToList();
    }
}
