using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
