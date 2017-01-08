using System;

namespace CatFactory.Diagnostics
{
    public class LogEntry
    {
        public LogEntry()
        {
        }

        public MessageType EntryType { get; set; }

        public String Message { get; set; }
    }
}
