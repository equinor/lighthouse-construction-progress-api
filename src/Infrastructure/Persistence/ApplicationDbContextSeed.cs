using System.Globalization;
using lighthouse_construction_progress_api.Domain.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace lighthouse_construction_progress_api.Infrastructure.Persistence;

public static class ApplicationDbContextSeed
{
    public static async Task SeedSampleDataAsync(ApplicationDbContext context)
    {

        //if (!context.Activities.Any())
        //{
        //    await context.AddAsync(new Activity() { ActivityNo = "Test" });

        //}

        // Seed, if necessary
        if (!context.WorkOrders.Any())
        {

            var lines = (await File.ReadAllLinesAsync("TextFile1.txt"))
                .Select(a => a.Split(';'));
            string[] formats = { "dd.MM.yyyy HH:mm", "dd.MM.yyyy" };
            foreach (string[] strings in lines)
            {
                var statusDate = new DateTime();
                var estimatedStartTime = new DateTime();
                var estimatedEndTime = new DateTime();
                int progress = 0;
                double hoursUsed = 0;
                try
                {
                     hoursUsed = strings[9] == string.Empty ? 0.0 : Double.Parse(strings[9]);
                     statusDate = DateTime.ParseExact(strings[4],formats,CultureInfo.InvariantCulture);
                     estimatedStartTime = DateTime.ParseExact(strings[5],formats,CultureInfo.InvariantCulture);
                     estimatedEndTime = DateTime.ParseExact(strings[6],formats,CultureInfo.InvariantCulture);
                     progress = Int32.Parse(strings[8]);
                }catch(FormatException){}
          
                await context.WorkOrders.AddAsync(new WorkOrder
                {
                WoNo = strings[0],
                ActivityNo = strings[1],
                Description = strings[2],
                Status = strings[3],
                StatusDate = statusDate,
                EstimatedStartTime = estimatedStartTime,
                EstimatedEndTime = estimatedEndTime,
                   Progress = progress,
                //TODO estimated hours
                
                HoursUsed = hoursUsed

                });
            }

            await context.SaveChangesAsync();
        }
    }
}
