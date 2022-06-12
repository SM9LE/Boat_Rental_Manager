using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boat_Rental.Manager
{
    public class CommandManager : DataManager
    {

        // Déclaration du client et du bateau pour les éditer lors de l'ajout d'une commande

        CustomerManager customerManager = new CustomerManager();
        BoatManager boatManager = new BoatManager();

        public Command AddACommand(Command command)
        {

            // Afin d'éviter l'erreur "set of an instance object null"

            if( command != null && customerManager != null && boatManager != null )
            {
                // Je récupère l'id du client ainsi que l'idée du bateau

                Customer customer = customerManager.FindACustomerByID(command.IdCustomer);
                Boat boat = boatManager.FindABoatByID(command.IdBoat);
                Context.Commands.Add(command);
                if (Context.SaveChanges() > 0)
                {
                    // Lorsque je valide l'ajout de la commande, je change l'état des booléens de customer et de boat

                    boat.IsRentedBoat = true;
                    customer.HasRentedCustomer = true;
                    customerManager.EditACustomer(customer);
                    boatManager.EditABoat(boat);
                    return command;
                }
            }
          
            return null;
        }
        public bool DeleteACommand(Command command)
        {
            if (command != null)
            {
                Context.Commands.Remove(command);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteACommand(int id)
        {
            Command command = FindACommandByCommandID(id);
            if (command == null)
                return false;
            return DeleteACommand(command);
        }
        public bool EditACommand(Command command)
        {
            Context.Entry(command).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }

        // Récupération d'une commande par son identifiant

        public Command FindACommandByCommandID(int id)
        {
            return Context.Commands.Find(id);
        }

        // Trouver une commande de client par l'identifiant du client

        public Command FindACommandByIDCustomerAndDate(int id, DateTime debut)
        {
            return Context.Commands.FirstOrDefault(command => command.IdCustomerNavigation.IdCustomer == id && command.DateStartCommand.Equals(debut));
        }

        // Trouver une commande par l'identifiant du bateau

        public Command FindACommandByBoatID(int idboat, DateTime debut)
            => Context.Commands.FirstOrDefault(command => command.IdBoat == idboat && command.DateStartCommand.Equals(debut));

       // Récupération de toutes les commandes

        public List<Command> ListCommands()
        {
            var list = Context.Commands
                .Include(cmd => cmd.IdBoatNavigation)
                .Include(cmd => cmd.IdCustomerNavigation)
                .AsQueryable();
            return list.OrderByDescending(command => command.DateEndCommand).ToList();
        }

        // Récupération d'une commande par le nom du client
        public List<Command> FindACommandByCustomerName(string first)
    => Context.Commands.Where(cmd => cmd.IdCustomerNavigation.LastNameCustomer.StartsWith(first)).ToList();

        public Command FindACommandByCustomerId(int id)
            => Context.Commands.FirstOrDefault(command => command.IdCustomer == id);

        public List<Command> top1/*BateauPrixLePlusCher*/()
        {
            var list = Context.Commands.AsQueryable();
            list = list.OrderByDescending(command => command.IdBoatNavigation.PriceBoat).Take(1);
            return list.ToList();
        }
    }
}
