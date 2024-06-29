using proyecto_final_prog2.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_prog2.Domain.Entities
{
    public class Tag : BaseEntity
    {
        [MaxLength(25)]
        [Required]
        public string tag_name { get; set; }
        public List<Task> tasks { get; set; } = [];
    }
}
