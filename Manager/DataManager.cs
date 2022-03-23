using Boat_Rental.Models;

namespace Boat_Rental.Manager
{
    public abstract class DataManager
    {
        public readonly Boat_RentalContext Context;

        public DataManager()
        {
            Context = new Boat_RentalContext();
        }
    }
}
