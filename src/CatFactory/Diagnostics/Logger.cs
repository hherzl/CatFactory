using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Diagnostics
{
    public class Logger
    {
        private static Logger m_detafult;

        public static Logger Default
        {
            get
            {
                return m_detafult ?? (m_detafult = new Logger());
            }
        }

        public Logger()
        {
        }

        public Boolean LogToConsole { get; set; }

        public Boolean AppendToOutputFile { get; set; }

        public String OutputFileName { get; set; }

        private List<LogEntry> m_stack;

        public List<LogEntry> Stack
        {
            get
            {
                return m_stack ?? (m_stack = new List<LogEntry>());
            }
        }

        public void Log(String message, params Object[] values)
        {
            var entry = new LogEntry
            {
                EntryType = MessageType.Message,
                Message = String.Format("{0} : {1}", DateTime.Now, String.Format(message, values))
            };

            Stack.Add(entry);

            if (Debugger.IsAttached)
            {
                Debug.WriteLine(entry);
            }

            if (LogToConsole)
            {
                Console.WriteLine(entry);
            }

            if (AppendToOutputFile)
            {
                TextFileHelper.AppendLine(OutputFileName, entry.Message);
            }
        }

        public void ClearFile()
        {
            TextFileHelper.Clear(OutputFileName);
        }
    }
}
