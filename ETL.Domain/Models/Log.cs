using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL.Domain.Models
{
    [Table("Log")]
    public class Log
    {
        int LogId { get; set; }
        public List<Entry> LogEntries { get; set; }
        public Log()
        {
            LogEntries = new List<Entry>();
        }
        public Log(List<Entry> logEntries)
        {
            LogEntries = logEntries;
        }
    }
}
