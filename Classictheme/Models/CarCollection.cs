using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Classictheme.Models
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("CarCollection")]
    public class CarCollection
    {
        [XmlArray("Cars")]
        [XmlArrayItem("Car", typeof(CarDetails))]
        public CarDetails[] Car { get; set; }
    }
}