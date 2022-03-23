using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boat_Rental.Manager
{
    public class BoatManager : DataManager
    {
        public Boat AddABoat(Boat boat)
        {
            Context.Boats.Add(boat);
            if (Context.SaveChanges() > 0)
                return boat;
            return null;
        }
        public bool DeleteABoat(Boat boat)
        {
            if (boat != null)
            {
                Context.Boats.Remove(boat);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteABoat(int id)
        {
            Boat boat = FindABoatByID(id);
            if (boat == null)
                return false;
            return DeleteABoat(boat);
        }
        public bool EditABoat(Boat boat)
        {
            Context.Entry(boat).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }
        public Boat FindABoatByID(int id)
        {
            return Context.Boats.Find(id);
        }
      /*  public Boat FindABoatByRent(bool rent)
        {
            Context.Boats.Where(boat => boat.IsRentedBoat == rent);
        }
      */
        public Boat FindABoatByLicense(string license)
            => Context.Boats.FirstOrDefault(boat => boat.LicenseBoat == license);
    }
}
