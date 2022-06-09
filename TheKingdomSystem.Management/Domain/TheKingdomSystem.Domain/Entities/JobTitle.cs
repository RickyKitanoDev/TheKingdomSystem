using TheKingdomSystem.Management.Domain.Generic;

namespace TheKingdomSystem.Management.Domain.Entities
{
    public class JobTitle : CommonEntity
    {
        public string Description { get; set; }
        public int Status { get; set; }
    }
}
