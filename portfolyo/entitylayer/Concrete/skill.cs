﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitylayer.Concrete
{
    public class skill
    {
        [Key]
        public int MyProperty { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
