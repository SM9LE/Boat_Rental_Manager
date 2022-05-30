using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace Boat_Rental.Manager
{
    public abstract class DataManager
    {
        public readonly Boat_RentalContext Context;

        public DataManager()
        {
            var test = new DbContextOptionsBuilder<Boat_RentalContext>().UseLazyLoadingProxies();
            Context = new Boat_RentalContext(test.Options);
        }
    }
}
