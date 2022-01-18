using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{ 
    public class SiteVisit: DomainObject
    {
       
       // public int Id { get; set; }
        public DateTime? DateTimeVisit { get; set; }
        public CheckList? CheckList { get; set; }
        public ICollection<Verification>? Verifications { get; set; }
        public string? Comments { get; set; }
        public Site? Site { get; set; }



}
}
