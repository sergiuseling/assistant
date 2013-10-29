using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApp.Models
{
    public class UserTask
    {
        public int UserTaskID { get; set; }
        public int UserID { get; set; }
        public int StudentID { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public virtual User User { get; set; }
    }
}
