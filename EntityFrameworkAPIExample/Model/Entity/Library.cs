using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkAPIExample.Model.Entity
{
    public class Library
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public Address Address { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
