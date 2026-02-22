using Microsoft.EntityFrameworkCore;
using SimplyWorks_UtilityMeasurement.Maui.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimplyWorks_UtilityMeasurement.Maui.Services
{
    public class DbInitializer
    {
        private readonly UtilityMeasurementDbContext _db;

        public DbInitializer(UtilityMeasurementDbContext db) => _db = db;

        public async Task InitializeAsync()
        {
            await _db.Database.MigrateAsync();
        }
    }
}
