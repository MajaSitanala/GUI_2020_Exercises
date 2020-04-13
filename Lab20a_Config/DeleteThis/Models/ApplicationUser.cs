using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() {}
        
        [Required]
        [PersonalData]
        public string AU_Name { get; set; }
        
        [PersonalData]
        public ICollection<Review> Reviews { get; set; }
    }
}
