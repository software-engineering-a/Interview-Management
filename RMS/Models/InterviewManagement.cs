using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RMS.Models
{
    public class InterviewManagement
    {
        public int ID { get; set; }

        public int UID { get; set; }
        [Display(Name ="Interview Date")]
        public DateTime interview_date { get; set; }
        [Display(Name = "Interview Time")]

        public TimeSpan time { get; set; }
        public string status { get; set; }
    }
}