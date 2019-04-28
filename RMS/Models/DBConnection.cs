using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RMS.Models
{
    public class DBConnection:DbContext
    {
        public DbSet<InterviewManagement> interview_mangement { get; set; }
    }
}