using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text;

namespace SimplyWorks_UtilityMeasurement.Maui.Models
{
    public class Apartment
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Code { get; set; } = string.Empty; // pl. "A/12"

        [MaxLength(200)]
        public string? Note { get; set; }

        public ICollection<Meter> Meters { get; set; } = new List<Meter>();
    }
}
