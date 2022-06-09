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
    public class JobTitleRepository : IJobTitleRepository
    {
        public JobTitleRepository(ManagementDataContext context)
        {
            _context = context;
        }
        private readonly ManagementDataContext _context;
        public async Task<List<JobTitle>> GetAllJobTitle()
        {
            var jobTitles = _context.JobTitle.ToList();
            return await Task.FromResult(jobTitles);
        }

        public async Task<JobTitle> GetJobTitleById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveJobTitle(JobTitle jobTitle)
        {
            await _context.JobTitle.AddAsync(jobTitle);
            await _context.SaveChangesAsync();
        }
    }
}
