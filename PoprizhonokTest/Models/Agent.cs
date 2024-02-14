using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class Agent
    {
        public int IdAgent { get; set; }
        public int? TypeAgentId { get; set; }
        public string? NameAg { get; set; }
        public string? Mail { get; set; }
        public string? Number { get; set; }
        public byte[]? Logo { get; set; }
        public string? Adres { get; set; }
        public int? Favorit { get; set; }
        public string? Director { get; set; }
        public long? Inn { get; set; }
        public int? Kpp { get; set; }

        public virtual TtpeAgent?  TypeAgent { get; set; }
    }
}
