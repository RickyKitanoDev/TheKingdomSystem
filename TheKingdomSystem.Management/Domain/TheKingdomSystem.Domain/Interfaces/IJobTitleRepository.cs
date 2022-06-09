using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Domain.Interfaces
{
    public interface IJobTitleRepository
    {
        Task SaveJobTitle(JobTitle jobTitle);
        Task<List<JobTitle>> GetAllJobTitle();
        Task<JobTitle> GetJobTitleById(int id);
        
    }
}
