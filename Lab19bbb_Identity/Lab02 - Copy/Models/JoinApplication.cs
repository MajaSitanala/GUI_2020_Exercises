using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02.Models
{
    public class JoinApplication
    {
        public long JoinApplicationId { get; set; }
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
        [Required]
        [MaxLength(64)]
        public string Email { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Experience { get; set; }
    }
}
