using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GestaoDesenvolvedores
{
    [Table("Allocations")]
    internal class Allocation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Byte AtuacionHoursPerWeek { get; set; }
        public Decimal Remuneration { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public int DeveloperId { get; set; }
        public List<Task> Tasks { get; set; }

        public Allocation() { }
        public Allocation(DateTime startDate, DateTime finishDate, byte atuacionHoursPerWeek, decimal remuneration, int project, int developer)
        {
            StartDate = startDate;
            FinishDate = finishDate;
            AtuacionHoursPerWeek = atuacionHoursPerWeek;
            Remuneration = remuneration;
            ProjectId = project;
            DeveloperId = developer;
        }
        public override string ToString()
        {
            return Id
                + ", StartDate: " + StartDate
                + ", FinishDate: " + FinishDate
                + ", AtuacionHoursPerWeek: " + AtuacionHoursPerWeek
                + ", Remuneration: " + Remuneration
                + ", Project: " + ProjectId
                + ", Developer: " + DeveloperId
                + ", Tasks: " + Tasks;
        }
    }
}
