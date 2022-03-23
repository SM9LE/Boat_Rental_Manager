using System;
using System.Collections.Generic;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Customer
    {
        public Customer(string text, string text1)
        {
            Commands = new HashSet<Command>();
        }

        public int IdCustomer { get; set; }
        public string FirstNameCustomer { get; set; }
        public string LastNameCustomer { get; set; }
        public DateTime AgeCustomer { get; set; }
        public string MailCustomer { get; set; }
        public string AdressCustomer { get; set; }
        public bool BoatLicenseCustomer { get; set; }
        public bool HasRentedCustomer { get; set; }

        public virtual ICollection<Command> Commands { get; set; }
        public Customer(string firstNameCustomer, string lastNameCustomer, DateTime ageCustomer, string mailCustomer, string adressCustomer, bool boatLicenseCustomer, bool hasRentedCustomer)
        {
            FirstNameCustomer = firstNameCustomer;
            LastNameCustomer = lastNameCustomer;
            AgeCustomer = ageCustomer;
            MailCustomer = mailCustomer;
            AdressCustomer = adressCustomer;
            BoatLicenseCustomer = boatLicenseCustomer;
            HasRentedCustomer = hasRentedCustomer;
        }
    }
}
