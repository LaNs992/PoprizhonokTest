using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class TtpeAgent
    {
        public TtpeAgent()
        {
            Agents = new HashSet<Agent>();
        }

        public int Id { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<Agent> Agents { get; set; }
    }
}
