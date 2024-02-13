using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitylayer.Concrete
{
    public class portfolio
    {
        [Key]
        public int portfolioID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string ImageUrl2 { get; set; }
    }
}
