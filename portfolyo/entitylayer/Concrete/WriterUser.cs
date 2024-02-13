using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.Concrete
{
    public class WriterUser:IdentityUser<int>
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string ımageurl { get; set; }
    }
}
