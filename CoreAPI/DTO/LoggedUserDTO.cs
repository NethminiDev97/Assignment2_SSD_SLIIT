using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.DTO
{
    public class LoggedUserDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string UserRole { get; set; }
        public string AuthToken { get; set; }
    }
}
