using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
   
    public class WorkOrder: DomainObject
    {
        
        //public int Id { get; set; }
        public string? Number { get; set; }
        public string? Description { get; set; }
        public bool? Completed { get; set; }
        public Site? Site { get; set; }

    }
}
