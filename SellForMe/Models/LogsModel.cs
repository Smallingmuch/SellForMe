using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellForMe.Models
{
    class LogsModel
    {
        public int Id { get; set; }
        public DateTime DateStamp {get; set;}
        public DateTime TimeStamp { get; set; }
        public string Narrative { get; set; }
        public string BusinessName { get; set; }
        public string StaffId { get; set; }
    }
}
