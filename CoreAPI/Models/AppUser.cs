﻿using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Models
{
    public class AppUser
    {
        [Key]
        public int  UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
    }
}
