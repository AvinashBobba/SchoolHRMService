using SchoolHRM.Service.Shared;
using System.Collections.Generic;

namespace SchoolHRM.Service.WebAPI.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
