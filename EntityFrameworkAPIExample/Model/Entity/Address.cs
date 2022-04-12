using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkAPIExample.Model.Entity
{
    public class Address
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(200)]
        public string StreetName { get; set; }
        [MaxLength(200)]
        public string StreetNo { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        [MaxLength(200)]
        public string City { get; set; }
        [MaxLength(200)]
        public string Country { get; set; }
    }
}
