namespace ChatWeb.Api.Shared.Helper;

public static class BogotaClock
{
    private static readonly TimeZoneInfo Zone = 
        TimeZoneInfo.FindSystemTimeZoneById("America/Bogota");

    public static DateTime Now => TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Zone);
}