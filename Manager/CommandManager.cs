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
        public Command FindACommandByCommandID(int id)
        {
            return Context.Commands.Find(id);
        }

        public Command FindACommandByBoatID(int idboat)
            => Context.Commands.FirstOrDefault(command => command.IdBoat == idboat);
    }
}
