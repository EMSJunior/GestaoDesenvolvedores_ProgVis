using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    [Table("Tasks")]
    internal class Task
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public String Description { get { return Description; }    set { Description = value.Substring(200); } }
        public Allocation Allocation { get; set; }

        public Task() { }
        public Task(String description, Allocation allocation)
        {
            Description = description;
            Allocation = allocation;
        }
    }
}
