using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Boat_Rental.Manager
{
    public class BoatManager : DataManager
    {
        public Timer timer;


        public void InitializeTimer()
        {

            timer = new Timer(60000);
            timer.Elapsed += CheckBoatRent;
            timer.Start();
        }

        private void CheckBoatRent(object sender, ElapsedEventArgs e)
        {
            foreach(var commandBoat in ListBoat().SelectMany(x => x.Commands))
            {
                if(commandBoat.DateEndCommand <= DateTime.Now)
                    commandBoat.IdBoatNavigation.IsRentedBoat = false;

                Context.Update(commandBoat.IdBoatNavigation);
            }
        }

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

        public List<Boat> FindBoatStartByLicense(string license)
            => Context.Boats.Where(boat => boat.LicenseBoat.StartsWith(license)).ToList();

        public List<Boat> ListBoat()
            => Context.Boats.ToList();

 
     public List<Boat> top5(string boat)
        {
            var list = Context.Boats.AsQueryable();
            list = list.OrderByDescending(boat => boat.NameBoat).Where(b => b.IsRentedBoat == true).Take(5);
            return list.ToList();
        }
  
    }
}
