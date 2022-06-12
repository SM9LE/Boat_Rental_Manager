using System;
using System.Collections.Generic;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Boat
    {
        public Boat()
        {
            Commands = new HashSet<Command>();
        }
        public int IdBoat { get; set; }
        public string NameBoat { get; set; }
        public string LicenseBoat { get; set; }
        public int SlotBoat { get; set; }
        public string DescriptionBoat { get; set; }
        public double PriceBoat { get; set; }
        public bool IsRentedBoat { get; set;}
        public int IdBoatType { get; set; }

        public virtual Boattype IdBoatTypeNavigation { get; set; }
        public virtual ICollection<Command> Commands { get; set; }
        public Boat(string nameBoat, string licenseBoat, int slotBoat, string descriptionBoat, double priceBoat, bool isRentedBoat, int idBoatType)
        {
            NameBoat = nameBoat;
            LicenseBoat = licenseBoat;
            SlotBoat = slotBoat;
            DescriptionBoat = descriptionBoat;
            PriceBoat = priceBoat;
            IsRentedBoat = isRentedBoat;
            IdBoatType = idBoatType;
        }
    }
}
