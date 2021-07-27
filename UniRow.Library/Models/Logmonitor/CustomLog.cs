using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniRow.Library.Models.Logmonitor
{
    public class CustomLog
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int UserId { get; set; }
        public DateTime LogDate { get; set; }
        public string Category { get; set; }
        public string Activity { get; set; }
        public int count { get; set; }
        public TimeSpan ActivityTime { get; set; }
        public string PhysicalExperience { get; set; }
        public string PsysicalExperience { get; set; }
        public string Comments { get; set; }
    }

}
