using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    internal class ProjectRepository
    {
        public static void Save(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Projects.Add(project);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
        public static List<Project> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.ToList();
                }
            }
            catch (Exception) { throw; }
        }
        public static List<Project> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects
                        .Where(p => p.Name.Contains(partialName))
                        .ToList<Project>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Project FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

  

        
    }
}
