using System.Globalization;
using System.Text.RegularExpressions;
using lighthouse_construction_progress_api.Domain.Entities;

namespace lighthouse_construction_progress_api.Infrastructure.Persistence;

public static class ApplicationDbContextSeed
{
    public static async Task SeedSampleDataAsync(ApplicationDbContext context)
    {
     
        if (!context.WorkOrders.Any())
        {
            IEnumerable<string[]> lines = (await File.ReadAllLinesAsync("WorkOrders.txt"))
                .Select(a => a.Split(';'));
            string[] formats = { "dd.MM.yyyy HH:mm", "dd.MM.yyyy" };
            foreach (string[] strings in lines)
            {
                DateTime statusDate = new();
                DateTime estimatedStartTime = new();
                DateTime estimatedEndTime = new();
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
            IEnumerable<string[]> lines = (await File.ReadAllLinesAsync("Objects.txt"))
                .Select(a => a.Split(';'));
            string[] formats = { "dd.MM.yyyy HH:mm", "dd.MM.yyyy", "dd.MM.yyyy HH:mm:ss" };
            foreach (string[] strings in lines)
            {
                try
                {
                    DateTime statusDate = new DateTime();
                    double estimatedQuantity = 0;
                    double installedQuantity = 0;
                    double remainingHours = 0;
                    try
                    {
                        remainingHours = strings[11] == string.Empty ? 0.0 : Double.Parse(strings[11]);
                        statusDate = strings[6] == string.Empty
                            ? statusDate
                            : DateTime.ParseExact(strings[6], formats, CultureInfo.InvariantCulture);
                        estimatedQuantity = strings[9] == string.Empty ? 0 : Double.Parse(strings[9]);
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
                        Cable_T_Area = strings[22]
                    });
                }
                catch (Exception e)
                {
                }
            }

            await context.SaveChangesAsync();
        }

        if (!context.Activities.Any())
        {
            IEnumerable<string[]> lines = (await File.ReadAllLinesAsync("Activities.txt"))
                .Select(a => a.Replace("FU;A","FU:A").Split(';'));
            string[] formats = { "dd.MM.yyyy HH:mm", "dd.MM.yyyy", "dd.MM.yyyy HH:mm:ss" };
            foreach (string[] strings in lines)
            {
                try
                {
                    long sequence = 0;
                    long netId = 0;
                    try
                    {
                        sequence = strings[2] == string.Empty ? 0 : Int64.Parse(strings[2]);
                        netId = strings[3] == string.Empty ? 0 : Int64.Parse(strings[3]);
                    }
                    catch (FormatException) { }

                    await context.Activities.AddAsync(new Activity()
                    {
                        ActivityNo = strings[0],
                        Description = strings[1],
                        Sequence = sequence, //2
                        NetId = netId, //3
                        F10 = strings[4],
                        R1Wbs = strings[5],
                        R1Description = strings[6],
                        R2MainCat = strings[7],
                        R2Description = strings[8],
                        R3Discipline = strings[9],
                        R3Description = strings[10], 
                        R4MainArea = strings[11], 
                        R4Description = strings[12],
                        R5SubArea = strings[13],
                        R5Description = strings[14],
                        R6System = strings[15],
                        R6Description = strings[16],
                        R7CommPk = strings[17],
                        R7Description = strings[18],
                        R8ProcurementPack = strings[19],
                        R8Description = strings[20],
                        R9Phase = strings[21],
                        R9Description = strings[22],
                        R10SubDiscipline = strings[23],
                        R10Description = strings[24],
                        R11Responsible = strings[25],
                        R11Description = strings[26],
                        R12ProjectMilestone = strings[27],
                        R12Description = strings[28],
                        R13ActivityRole = strings[29],
                        R13Description = strings[30],
                        R14ProjectPhase = strings[31],
                        R14Description = strings[32],
                        R15Fav = strings[33],
                        R15Description = strings[34],
                        R16Fas = strings[35],
                        R16Description =  strings[36],
                        R17Pau =  strings[37],
                        R17Description =  strings[38],
                        R18Module =  strings[39],
                        R18Description =  strings[40],
                        R19SapWbs =  strings[41],
                        R19Description =  strings[42],
                        R20Contract =  strings[43],
                        R20Description =  strings[44],
                        R21SubSystem =  strings[45],
                        R21Description = strings[46],
                        R22MaterialAllocationPhase =  strings[47],
                        R22Description =  strings[48],
                        R23ContractorCode =  strings[49],
                        R23Description =  strings[50],
                        R24CostCenterDepartment =  strings[51],
                        R24Description =  strings[52],
                        R25McPk =  strings[53],
                        R25Description =  strings[54],
                        R26TagTest =  strings[55],
                        R26Description =  strings[56],
                        R27SiteLocation =  strings[57],
                        R27Description =  strings[58],
                        R28WorkType =  strings[59],
                        R28Description =  strings[60],
                        R29JobDisc =  strings[61],
                        R29Description =  strings[62],
                        R30PersonalSortField =  strings[63],
                        R30Description =  strings[64],
                        Du =  ParseDouble(strings[65]),
                        Tse = ParseDate(strings[66],formats),
                        Acs = ParseDate(strings[67],formats),
                        Es = ParseDate(strings[68],formats),
                        Ef =  ParseDate(strings[69],formats),
                        Ls =  ParseDate(strings[70],formats),
                        Lf =  ParseDate(strings[71],formats),
                        OnTarget = ParseDouble(strings[72]),
                        CurrentProgress =  ParseDouble(strings[73]),
                        Cancelled =  ParseDate(strings[74],formats),
                        JobPackEstimatedQuantity =  ParseDouble(strings[75]),
                        ExpendedQuantity =  ParseDouble(strings[76]),
                        Esa =  ParseDate(strings[77],formats),
                        CurrentAs =  ParseDate(strings[78],formats),
                        CurrentAf =  ParseDate(strings[79],formats),
                        CurrentPlannedProgress = ParseDouble(strings[80]),
                        BasePlannedProgress =  ParseDouble(strings[81]),
                        Bes = ParseDate(strings[82],formats),
                        Besa =  ParseDate(strings[83],formats),
                        Bef =  ParseDate(strings[84],formats),
                        Rsh = ParseDouble(strings[85]),
                        Csh = ParseDouble(strings[86]),

                    });
                }
                catch (Exception e)
                {
                }
            }

            await context.SaveChangesAsync();
        }
    }

    private static double ParseDouble(string val)
    {
        try
        {
            string trim = Regex.Replace( val, @"s", "" );
            return trim == string.Empty ? 0 : Double.Parse(trim.Replace("�",""));
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
        }

        return 0;

    }

    private static DateTime ParseDate(string date, string[] formats)
    {
        DateTime parsedDate = new() ;
        try
        {
            return date == string.Empty
                ? parsedDate
                : DateTime.ParseExact(date, formats, CultureInfo.InvariantCulture);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e);
        }

        return parsedDate;

    }
}