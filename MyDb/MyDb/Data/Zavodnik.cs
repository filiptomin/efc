using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDb.Data
{
    class Zavodnik
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Represent { get; set; }
        [Required]
        public int age { get; set; }
        public ICollection<ZavodnikZavod> ZavodnikZavods { get; set; }
    }
}
