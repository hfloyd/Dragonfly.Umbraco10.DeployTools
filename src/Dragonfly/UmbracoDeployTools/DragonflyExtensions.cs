namespace Dragonfly.UmbracoDeployTools
{
    using System;

    public static class DragonflyExtensions
    {
        public static string GetReadableUtcTimestamp(this DateTime Date, bool ConvertToLocalTime)
        {
            if (Date != default(DateTime))
            {
                if (ConvertToLocalTime)
                {
                    var localTime = Date.ToLocalTime();
                    var localZone = TimeZone.CurrentTimeZone;
                    var zoneString = localZone.IsDaylightSavingTime(localTime) ? localZone.DaylightName : localZone.StandardName;
                    return $"{localTime.ToString("MMM d, yyyy hh:mm:ss tt")} ({zoneString})";
                }
                else
                {
                    return Date.ToString("yyyy-MM-dd-HH-mm-ss-UTC");
                }

            }
            else
            {
                return "NONE";
            }
        }


    }
}
