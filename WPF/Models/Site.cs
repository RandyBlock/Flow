using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public enum Area
    {
        North,
        East,
        South,
        West
    }

    public class Site: DomainObject
    {
       // public int Id { get; set; }

        [MaxLength(20)]
        public string? Acronym { get; set; }

        [MaxLength(200)]
        public Address? Address { get; set; }
        public Area? Area { get; set; }
        
        [MaxLength(8)]
        public string? MHNumber { get; set; }

        [MaxLength(32)]
        public string? Chainage { get; set; }

        /*Orbit Number */
        [MaxLength(100)]
        public string? Drawing { get; set; }

        /*Orbit Number */
        [MaxLength(100)]
        public string? TMP { get; set; }
        public ICollection<WorkOrder>? WorkOrders { get; set; }
        
      

    }
}
