using Boat_Rental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boat_Rental.Manager
{
    public class MemberManager : DataManager
    {
        public Member AddAMember(Member member)
        {
            Context.Members.Add(member);
            if (Context.SaveChanges() > 0)
                return member;
            return null;
        }
        public bool DeleteAMember(Member member)
        {
            if (member != null)
            {
                Context.Members.Remove(member);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteAMember(int id)
        {
            Member member = FindAMemberByID(id);
            if (member == null)
                return false;
            return DeleteAMember(member);
        }
        public bool EditAMember(Member member)
        {
            Context.Entry(member).State = EntityState.Modified;
            return Context.SaveChanges() > 0;
        }
        public Member FindAMemberByID(int id)
        {
            return Context.Members.Find(id);
        }

        public Member FindAMemberByLogin(string loginMember)
            => Context.Members.FirstOrDefault(member => member.LoginMember == loginMember);

        public List<Member> GetMember()
            => Context.Members.ToList();
    }
}
