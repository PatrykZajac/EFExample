using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkAPIExample.Model.Entity
{
    public class BookToCategory
    {
        [Key]
        public long Id { get; set; }
        public Book Book { get; set; }
        public Category Category { get; set; }
    }
}
