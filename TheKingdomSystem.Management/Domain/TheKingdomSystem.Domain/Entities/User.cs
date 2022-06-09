using TheKingdomSystem.Management.Domain.Generic;
using TheKingdomSystem.Management.Domain.Shared;

namespace TheKingdomSystem.Management.Domain.Entities
{
    public class User : CommonEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public Employee Employee { get; set; }      
    }
}
