using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyDb.Data
{
    class ZavodnikZavod
    {
        [Key]
        public int ZavodnikID { get; set; }

        [Key]
        public int ZavodID { get; set; }
        [ForeignKey("ZavodID")]
        public Zavod Zavod { get; set; }
        [ForeignKey("ZavodnikID")]
        public Zavodnik Zavodnik { get; set; }
    }
}
