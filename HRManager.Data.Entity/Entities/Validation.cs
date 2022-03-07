﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Data.Entity.Entities
{
    public class Validation:EntityBase
    {
        public int Id { get; set; }
        public bool Submitted { get; set; }
        public bool PDValidated { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
