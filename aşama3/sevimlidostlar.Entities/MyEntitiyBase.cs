using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.Entities
{
   public class MyEntitiyBase
    {
        public int Id { get; set; }
 
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public DateTime Createon { get; set; }
        [Required]
        public DateTime Modifiedon { get; set; }
        [Required,StringLength(30)]
        public string ModifiedUsername { get; set; }
    }
}
