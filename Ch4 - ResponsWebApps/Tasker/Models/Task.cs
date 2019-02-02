using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tasker.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskBody { get; set; }
        public DateTime DueDate { get; set; }
    }
}