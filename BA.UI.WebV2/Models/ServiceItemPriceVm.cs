﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BA.UI.WebV2.Models
{
    public class ServiceItemPriceVm
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDateTime { get; set; }
    }
}
