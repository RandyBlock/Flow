using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class Address : DomainObject
    {
        [MaxLength(60)]
        public string? Street { get; set; }
        [MaxLength(20)]
        public string? StreetNumber { get; set; }
        [MaxLength(50)]
        public string? City { get; set; }
        [MaxLength(60)]
        public string? GPSLocation { get; set; }
        public Site? Site { get; set; }

    }
}
