﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EvalAppCoreAut.Models
{
    public class Clients
    {
        [Key]
        public int ClientID { get; set; }
        public string ClientName { get; set; }
    }
}
