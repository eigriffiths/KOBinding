﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOBinding.model
{
    public class SalesOrder : IObjectWithState
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PoNumber { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}
