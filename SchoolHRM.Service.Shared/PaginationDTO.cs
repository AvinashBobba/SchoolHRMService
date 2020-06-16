using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHRM.Service.Shared
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;
        public int Size { get; set; }
    }
}
