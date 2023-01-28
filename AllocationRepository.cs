using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    internal class AllocationRepository
    {
        public static void Save(Allocation aloc)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Projects.Attach(aloc.Project);
                    dbContext.Developers.Attach(aloc.Developer);

                    dbContext.Allocations.Add(aloc);
                    dbContext.SaveChanges();
                }
            }
            catch
            { 
                throw;
            }
        }
    }
}
