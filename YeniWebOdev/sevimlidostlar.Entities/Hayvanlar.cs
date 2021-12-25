using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.Entities
{
    [Table("Hayvanlar")]
   public  class Hayvanlar:MyEntitiyBase
    {
        [Required,StringLength(30)]
        public string name { get; set; }

        [Required, StringLength(30)]
        public string Description { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Kategori> Kategoris { get; set; }
        public int kategoriId { get; set; }


    }
}
