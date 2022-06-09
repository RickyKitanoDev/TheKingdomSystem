using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Database.DatabaseContext;
using TheKingdomSystem.Management.Domain.Entities;
using TheKingdomSystem.Management.Domain.Interfaces;

namespace TheKingdomSystem.Management.Database.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public AddressRepository(ManagementDataContext context)
        {
            _context = context;
        }
        private readonly ManagementDataContext _context;
        public async Task<Address> GetAddressById(int id)
        {
            var getAddressById = await _context.Address.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            if (getAddressById != null)
                return getAddressById;
            return null;
        }

        public async Task<List<Address>> GetAllAddress()
        {
            var address = _context.Address.ToList();
            return await Task.FromResult(address);
        }

        public async Task SaveAddress(Address address)
        {
            await _context.Address.AddAsync(address);
            await _context.SaveChangesAsync();
        }             
        public Task<Address> AlterAddressId(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address> DeleteAddressId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
