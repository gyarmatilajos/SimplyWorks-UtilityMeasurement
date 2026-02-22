using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static SimplyWorks_UtilityMeasurement.Maui.Models.Enums;

namespace SimplyWorks_UtilityMeasurement.Maui.Models
{
    public class Meter
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string SerialNumber { get; set; } = string.Empty; // vonalkód tartalma (egyedi)

        public MeterScope Scope { get; set; }
        public MeterKind Kind { get; set; }
        public UnitOfMeasure Unit { get; set; }

        public bool IsActive { get; set; } = true;

        // Individual esetén kötelező, Common esetén null
        public int? ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }

        public ICollection<Reading> Readings { get; set; } = new List<Reading>();
    }
}
