﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MilSpace.GeoCalculator.BusinessLogic.Models
{
    [Serializable]
    [XmlRoot("PointModelsList")]
    public class PointModel
    {
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double WgsXCoord { get; set; }
        public double WgsXCoordDD { get; set; }
        public double WgsYCoord { get; set; }
        public double WgsYCoordDD { get; set; }
        public double PulkovoXCoord { get; set; }
        public double PulkovoXCoordDD { get; set; }
        public double PulkovoYCoord { get; set; }
        public double PulkovoYCoordDD { get; set; }
        public double UkraineXCoord { get; set; }
        public double UkraineXCoordDD { get; set; }
        public double UkraineYCoord { get; set; }
        public double UkraineYCoordDD { get; set; }
        public string MgrsRepresentation { get; set; }
        public string UtmRepresentation { get; set; }
    }
}
