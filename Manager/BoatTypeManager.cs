using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boat_Rental.Manager
{
    public class BoatTypeManager : DataManager
    {
        public Boattype AddABoatType(Boattype boattype)
        {
            Context.Boattypes.Add(boattype);
            if (Context.SaveChanges() > 0)
                return boattype;
            return null;
        }   
        public bool DeleteABoatType(Boattype boattype)
        {
            if (boattype != null)
            {
                Context.Boattypes.Remove(boattype);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteABoatType(int id)
        {
            Boattype boattype = FindABoatTypeByID(id);
            if (boattype == null)
                return false;
            return DeleteABoatType(boattype);
        }
        public bool EditABoatType(Boattype boattype)
        {
            Context.Entry(boattype).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);
        }
        public Boattype FindABoatTypeByID(int id)
        {
            return Context.Boattypes.Find(id);
        }
        public Boattype FindABoatTypeByType(string type)
            => Context.Boattypes.FirstOrDefault(boattype => boattype.TypeBoatType == type);
        public List<Boattype> ListBoattype()
           => Context.Boattypes.ToList();
    }
}
