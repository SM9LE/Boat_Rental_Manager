using System;
using System.Collections.Generic;

#nullable disable

namespace Boat_Rental.Models
{
    public partial class Member
    {
        public int IdMember { get; set; }
        public string LoginMember { get; set; }
        public string PasswordMember { get; set; }
        public Member(string loginMember, string passwordMember)
        {
            LoginMember = loginMember;
            PasswordMember = passwordMember;
        }
    }
}
