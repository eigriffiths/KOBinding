using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KOBinding.model;

namespace KOBinding.web.ViewModels
{
    public class SalesOrderViewModel : IObjectWithState
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PoNumber { get; set; }

        public string MessageToClient { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}
