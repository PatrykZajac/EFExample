using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkAPIExample.Model.Entity
{
    public class Author
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(200)]
        public string FirstName { get; set; }
        [MaxLength(200)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
