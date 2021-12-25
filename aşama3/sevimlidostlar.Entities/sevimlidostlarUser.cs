using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevimlidostlar.Entities
{
    [Table("sevimlidostlarUser")]
    public class sevimlidostlarUser: MyEntitiyBase
    {
        [StringLength(30)]
        public string name { get; set; }
        [StringLength(30)]
        public string surname { get; set; }
        [Required, StringLength(30)]
        public string username { get; set; }
        [Required, StringLength(100)]
        public string email { get; set; }
        [Required, StringLength(100)]
        public string password { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        [Required]
        public Guid ActiveGuid { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Hayvanlar> hayvan { get; set; }


    }
}
