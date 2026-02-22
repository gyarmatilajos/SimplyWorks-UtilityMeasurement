using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static SimplyWorks_UtilityMeasurement.Maui.Models.Enums;

namespace SimplyWorks_UtilityMeasurement.Maui.Models
{
    public class Reading
    {
        public int Id { get; set; }

        public int MeterId { get; set; }
        public Meter Meter { get; set; } = default!;

        public DateTime ReadAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "TEXT")] // SQLite-ban nem számít, de jelzésnek jó
        public decimal Value { get; set; }

        [MaxLength(250)]
        public string? Note { get; set; }

        [MaxLength(500)]
        public string? PhotoPath { get; set; }
    }
}
