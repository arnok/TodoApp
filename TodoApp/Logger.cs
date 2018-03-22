using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Logger
    {
        // Log levels derived from the monolog log level specification
        public enum logLevel : int { debug = 100, info = 200, notice = 250, warning = 300, error = 400, critical = 500, alert = 500, emergency = 600 };

        private static string logFileName = "log.txt";

        // Logs message
        public static void log(logLevel LogLevel, string message)
        {
            writeLog(format(LogLevel, message));
        }

        // Formats a log message
        private static string format(logLevel LogLevel, string message)
        {
            return string.Format("[{0}] {1} - {2}", LogLevel, getTimeDate(), message);
        }

        // Write to the log file
        private static void writeLog(string logLine)
        {
            using (StreamWriter w = File.AppendText(logFileName))
            {
                w.WriteLine(logLine);
            }
        }

        // Get a time date string
        private static string getTimeDate()
        {
            return string.Format("{0}@{1}",
                DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString()
            );
        }
    }
}
