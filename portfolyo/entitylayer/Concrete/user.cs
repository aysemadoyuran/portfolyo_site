using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.Concrete
{
    public class user
    {
        [Key]
        public int userıd { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string ımageurl { get; set; }
        public bool status { get; set; }
        public List< usermessage > usermessages{ get; set; }
    }
}
