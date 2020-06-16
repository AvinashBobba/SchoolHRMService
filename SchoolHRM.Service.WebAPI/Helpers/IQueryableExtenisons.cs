using SchoolHRM.Service.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolHRM.Service.WebAPI.Helpers
{
    public static class IQueryableExtenisons
    {
        public static IQueryable<T> Paginate<T>(
            this IQueryable<T> queryable ,
            PaginationDTO paginationDTO
            )
        {
            return queryable
                .Skip((paginationDTO.Page - 1)* paginationDTO.Size)
                .Take(paginationDTO.Size);
        }
    }
}
