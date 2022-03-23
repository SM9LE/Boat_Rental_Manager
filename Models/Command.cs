using System;
using System.Collections.Generic;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Command
    {

        public int IdCommand { get; set; }
        public bool IsReadyCommand { get; set; }
        public DateTime DateStartCommand { get; set; }
        public DateTime DateEndCommand { get; set; }
        public double PriceCommand { get; set; }
        public bool HasPaiedCommand { get; set; }
        public bool HasPaiedDepositCommand { get; set; }
        public int IdCustomer { get; set; }
        public int IdBoat { get; set; }

        public virtual Boat IdBoatNavigation { get; set; }
        public virtual Customer IdCustomerNavigation { get; set; }
        public Command(bool isReadyCommand, DateTime dateStartCommand, DateTime dateEndCommand, double priceCommand, bool hasPaiedCommand, bool hasPaiedDepositCommand, int idCustomer, int idBoat)
        {
            IsReadyCommand = isReadyCommand;
            DateStartCommand = dateStartCommand;
            DateEndCommand = dateEndCommand;
            PriceCommand = priceCommand;
            HasPaiedCommand = hasPaiedCommand;
            HasPaiedDepositCommand = hasPaiedDepositCommand;
            IdCustomer = idCustomer;
            IdBoat = idBoat;
        }
    }
}
