using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    [Table("Developer_Levels")]
    internal class Level
    {

        public int Id { get; set; }
        [StringLength(30)]
        public String Text { get; set; }

        public Level() { }
        public Level(string text)
        {
            Text = text;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
