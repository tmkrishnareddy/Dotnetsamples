using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classictheme.Models
{
    [Serializable()]
    public class CarDetails
    {
        
        public string StockNumber { get; set; }

        
        public string Make { get; set; }

        
        public string Model { get; set; }
    }
}