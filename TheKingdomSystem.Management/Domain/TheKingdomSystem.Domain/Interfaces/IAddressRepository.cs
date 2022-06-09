using System.Collections.Generic;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Domain.Interfaces
{
    public interface IAddressRepository
    {
        Task SaveAddress(Address address);
        Task<List<Address>> GetAllAddress();
        Task<Address> GetAddressById(int id);       
        Task<Address> AlterAddressId(Address address);
        Task<Address> DeleteAddressId(int id);
    }
}
