using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class AgentsOfProduct
    {
        public int ProductId { get; set; }
        public int AgentId { get; set; }
        public DateTime? Date { get; set; }
        public int? Count { get; set; }

        public virtual Agent Agent { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
