using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.Entities
{
    [Table("kategoris")]
    public class Kategori:MyEntitiyBase
    {
       [Required,StringLength(40)]
        public string Title { get; set; }
        public virtual List<Hayvanlar> hayvan { get; set; }


    }
}
