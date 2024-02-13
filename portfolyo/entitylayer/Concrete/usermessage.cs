using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayer.Concrete
{
    public class usermessage
    {
        [Key]
        public int messageID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }
        public int userıd { get; set; }
        public user user { get; set; }

    }
}
