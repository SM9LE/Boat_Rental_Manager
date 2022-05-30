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
        public Command AddACommand(Command command)
        {
            Context.Commands.Add(command);
            if (Context.SaveChanges() > 0)
                return command;
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

        public Command FindACommandByIDCustomer(int id, DateTime debut)
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
            return list.ToList();
        }

        // Récupération d'une commande par le nom du client
        public List<Command> FindACommandByCustomerName(string first)
    => Context.Commands.Where(cmd => cmd.IdCustomerNavigation.LastNameCustomer.StartsWith(first)).ToList();
    }
}
