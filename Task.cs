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
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public String Describe { get { return Describe; }    set { Describe = value.Substring(200); } }
    }
}
