using System;
using System.Collections.Generic;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Boattype
    {
        public Boattype()
        {
            Boats = new HashSet<Boat>();
        }

        public int IdBoatType { get; set; }
        public string TypeBoatType { get; set; }

        public virtual ICollection<Boat> Boats { get; set; }
        public Boattype(string typeBoatType)
        {
            TypeBoatType = typeBoatType;
        }
    }
}
