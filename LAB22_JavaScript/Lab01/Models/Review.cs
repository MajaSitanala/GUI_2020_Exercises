using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01.Models
{
    public class Review
    {
        // P R I M A R Y    K E Y
        public long ReviewId { get; set; }

        // F O R I G E N     K E Y
        [MaxLength(450)]
        public string ApplicationUserId { get; set; }
        
        // A P P L I C A T I O N     U S E R
        [DisplayName("Customer")]
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; }
        
        // T H E     R E V I E W     C O N T E N T
        [DisplayName("Review")]
        [MaxLength(2000)]
        public string Comment { get; set; }
    }
}
