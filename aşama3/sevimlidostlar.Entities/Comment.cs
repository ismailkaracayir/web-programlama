using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.Entities
{
    [Table("Comments")]
    public class Comment:MyEntitiyBase
    {
        [Required,StringLength(350)]
        public string text { get; set; }
        public virtual Hayvanlar hayvanlar { get; set; }
        public virtual sevimlidostlarUser user { get; set; }
    }
}
