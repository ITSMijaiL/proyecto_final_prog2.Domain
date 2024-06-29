using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using proyecto_final_prog2.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyecto_final_prog2.Domain.Entities
{
    public class Task : BaseEntity
    {
        [MaxLength(100)]
        [Required]
        public string title { get; set; }
        
        [MaxLength(1200)]
        [Required]
        public string text{ get; set; }

        //[Required]
        //public Column column { get; set; } //reserved for the relation with the column.
        
        public List<Tag> tags { get; set; } = [];
    }
}
