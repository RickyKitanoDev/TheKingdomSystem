using System;
using TheKingdomSystem.Management.Domain.Generic;

namespace TheKingdomSystem.Management.Domain.Entities
{
    public class Employee : CommonEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime DateBirth { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public int Status { get; set; }
        public DateTime DateOfEntry { get; set; }
        public JobTitle JobTitle { get; set; }
        public Address Address { get; set; }
    }
}
