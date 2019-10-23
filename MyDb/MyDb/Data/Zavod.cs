using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyDb.Data
{
    class Zavod
    {
       [Key]
       public int ID { get; set; }
       [Required]
       public string Name { get; set; }
       [Required]
       public string Place { get; set; }
       [Required]
       public int Date { get; set; }
       public ICollection<ZavodnikZavod> ZavodnikZavods { get; set; } 
    }
}
