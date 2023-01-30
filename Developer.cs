using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    [Table("devs")]
    internal class Developer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(45)]  
        public string Name { get; set; }
        public DateTime BdayDate { get; set; }
        [Required]
        public Level Level { get; set; }
        public Credential Credential { get; set; }

        public List<Allocation> Allocations { get; set; }

        public Developer() { }
        public Developer(string name, DateTime bdayDate, Level level)
        {
            Name = name;
            BdayDate = bdayDate;
            Level = level;
        }

        public override string ToString()
        {
            return Id
                + ", " + Name
                + ", Level: " +  Level
                + ", Credencial: " + Credential?.Id;
        }
    }
}
