using proyecto_final_prog2.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace proyecto_final_prog2.Domain.Entities
{
    public class Column : BaseEntity
    {
        [MaxLength(100)]
        [Required]
        public string column_title { get; set; }

        [Required]
        public virtual ICollection<Task> tasks { get; set; } = new List<Task>();
    }
}
