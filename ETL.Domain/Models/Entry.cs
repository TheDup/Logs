using ETL_Error_Logging.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL.Domain.Models
{

    public class Entry
    {
        int EntryId { get; set; }
        LogType? logType { get; set; }
        string? Middleware { get; set; }
        string? Message { get; set; }
        string? Class { get; set; }
        List<String>? StackTrace;
        public Entry(string sLogType, string Message, string middleware, string eclass, List<String> stackTrace)
        {
            logType = Enum.Parse<LogType>(sLogType, true);
            Middleware = middleware;
            Class = eclass;
            StackTrace = stackTrace;
        }
    }
}
