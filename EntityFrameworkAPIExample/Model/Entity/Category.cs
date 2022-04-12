using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkAPIExample.Model.Entity
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public virtual ICollection<BookToCategory> Books { get; set; }
    }
}
