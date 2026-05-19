using System.Diagnostics;

namespace CarRentalSystem.Utilities
{
    public class clsEventLogger
    {
        private static string SourceName = "CarRental_System";
        private static string LogName = "Application";

        public static void Log(string Message, EventLogEntryType Type)
        {
            try
            {
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, LogName);
                }

                EventLog.WriteEntry(SourceName, Message, Type);
            }
            catch
            {
            }
        }
    }

}
