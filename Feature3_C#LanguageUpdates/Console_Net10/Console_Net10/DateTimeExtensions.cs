namespace Console_Net10;

public static class DateTimeExtensions
{
    extension(DateTime)
    {
        public static DateTime GetTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }

        public static DateTime GetYesterday()
        {
            return DateTime.Now.AddDays(-1);
        }
    }
}
