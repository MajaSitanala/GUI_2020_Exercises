using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02.Models
{
    public class Illustration
    {
        public int IllustrationId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ThumbNailId { get; set; }
        public string ImageUrl { get; set; }
    }
}
