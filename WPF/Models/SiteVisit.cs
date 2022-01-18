using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{ 
    public class SiteVisit : DomainObject
    {
       
        public DateTime? DateTimeVisit { get; set; }
    
        public string? Comments { get; set; }
        public CheckList? CheckList { get; set; }
        public ICollection<ClampOn>? ClampOn { get; set; }
        public ICollection<Dye>? Dye { get; set; }
        public ICollection<Manual>? Manual { get; set; }

        public Site? Site { get; set; }



    }
}
