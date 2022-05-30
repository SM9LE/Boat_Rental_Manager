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

        // Fonction permettant de trouver un client par son identifiant

        public Customer FindACustomerByID(int id)
        {
            return Context.Customers.Find(id);
        }

        // Fonction permettant de trouver un client par son adresse mail 

        public Customer FindACustomerByMail(string mail)
            => Context.Customers.FirstOrDefault(customer => customer.MailCustomer == mail);

        // Fonction permettant de récupérer tous les clients dans une liste

        public List<Customer> GetCustomers()
            => Context.Customers.ToList();

        // Fonction permettant de récupérer les clients par nom de famille

        public List<Customer> FindCustomersByName(string name)
            => Context.Customers.Where(customer => customer.LastNameCustomer.StartsWith(name)).ToList();

        // Fonction permettant de récupérer les clients ayant une location en cours
        public List<Customer> FindCustomersByRent()
            => Context.Customers.Where(customer => customer.HasRentedCustomer.Equals(true)).OrderByDescending(customer => customer.LastNameCustomer).ToList();
    }
}
