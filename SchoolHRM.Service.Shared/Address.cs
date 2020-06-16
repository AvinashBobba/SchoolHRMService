using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHRM.Service.Shared
{
    public class Address
    {
        public int AddressId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string AddressLine3 { get; set; }

        public string PostCode { get; set; }

        public string Country { get; set; }
    }
}
