using SchoolHRM.Service.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolHRM.Service.ServerApp.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
