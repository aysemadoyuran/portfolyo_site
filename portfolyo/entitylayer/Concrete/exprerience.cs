using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitylayer.Concrete
{
    public class exprerience
    {
        [Key]
        public int exprerienceID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

    }
}
