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

            var lines = (await File.ReadAllLinesAsync("WorkOrders.txt"))
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
                    statusDate = DateTime.ParseExact(strings[4], formats, CultureInfo.InvariantCulture);
                    estimatedStartTime = DateTime.ParseExact(strings[5], formats, CultureInfo.InvariantCulture);
                    estimatedEndTime = DateTime.ParseExact(strings[6], formats, CultureInfo.InvariantCulture);
                    progress = Int32.Parse(strings[8]);
                }
                catch (FormatException) { }

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

        if (!context.LciObjects.Any())
        {

            var lines = (await File.ReadAllLinesAsync("Objects.txt"))
                .Select(a => a.Split(';'));
            string[] formats = { "dd.MM.yyyy HH:mm", "dd.MM.yyyy", "dd.MM.yyyy HH:mm:ss" };
            foreach (string[] strings in lines)
            {
                try
                {
                    var statusDate = new DateTime();
                    double estimatedQuantity = 0;
                    double installedQuantity = 0;
                    double remainingHours = 0;
                    try
                    {
                        remainingHours = strings[11] == string.Empty ? 0.0 : Double.Parse(strings[11]);
                        statusDate = strings[6] == string.Empty ? statusDate : DateTime.ParseExact(strings[6], formats, CultureInfo.InvariantCulture);
                        estimatedQuantity= strings[9] == string.Empty ? 0 : Double.Parse(strings[9]);
                        installedQuantity = strings[10] == string.Empty ? 0 : Double.Parse(strings[10]);
                    }
                    catch (FormatException) { }

                    await context.LciObjects.AddAsync(new LciObject
                    {
                        ObjectNo = strings[0],
                        Name = strings[1],
                        Type = strings[2],
                        ActionNo = strings[3],
                        Status = strings[4],
                        StatusName = strings[5],
                        StatusDate = statusDate, //6
                        WorkTypeNo = strings[7],
                        WorkTypeName = strings[8],
                        EstimatedQuantity = estimatedQuantity, //9
                        InstalledQuantity = installedQuantity, //10
                        RemainingHours = remainingHours, //11
                        ActivityNo = strings[12],
                        ActivityName = strings[13],
                        WorkOrderNo = strings[14],
                        WorkOrderName = strings[15],
                        PipeTest = strings[16],
                        McPkg = strings[17],
                        ComPkg = strings[18],
                        Cable_F_Tag = strings[19],
                        Cable_F_Area = strings[20],
                        Cable_T_Tag = strings[21],
                        Cable_T_Area = strings[22],

                    });
                }
                catch (Exception e)
                {

                }
            }

            await context.SaveChangesAsync();

            

            //if (!context.LciObjects.Any())
            //{
            //    var lines = (await File.ReadAllLinesAsync("Activities.txt"))
            //        .Select(a => a.Split(';'));

            //    await context.SaveChangesAsync();
            //}
        }
    }
}
