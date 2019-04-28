using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RMS.Models
{
    public class InterviewManagement
    {
        public int ID { get; set; }
        public int UID { get; set; }
        public DateTime interview_date { get; set; }
        public TimeSpan time { get; set; }
        public string status { get; set; }
    }
}