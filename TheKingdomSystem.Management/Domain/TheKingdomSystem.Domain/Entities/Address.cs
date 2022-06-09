using TheKingdomSystem.Management.Domain.Generic;

namespace TheKingdomSystem.Management.Domain.Entities
{
    public class Address : CommonEntity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
