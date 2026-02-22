using System;
using System.Collections.Generic;
using System.Text;

namespace SimplyWorks_UtilityMeasurement.Maui.Models
{
    public class Enums
    {
        public enum MeterScope
        {
            Individual = 1,
            Common = 2
        }

        public enum MeterKind
        {
            ColdWater = 1,
            HotWater = 2,
            Heat = 3,
            Electricity = 4,
            Gas = 5
        }

        public enum UnitOfMeasure
        {
            CubicMeter = 1,   // m³
            KiloWattHour = 2, // kWh
            GigaJoule = 3     // GJ
        }           
    }
}
