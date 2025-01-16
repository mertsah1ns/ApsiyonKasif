using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApsiyonKasif.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? BirthPlace { get; set; }
        public string? IdentityNumber { get; set; }
        public string? MotherName { get; set; }
        public string? FatherName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
