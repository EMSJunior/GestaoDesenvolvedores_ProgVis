using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    if(aloc.Project != null) 
                    { 
                        dbContext.Projects.Attach(aloc.Project); 
                    }
                    if (aloc.Developer != null)
                    {
                        dbContext.Developers.Attach(aloc.Developer);
                    }

                    dbContext.Allocations.Add(aloc);
                    dbContext.SaveChanges();
                }
            }
            catch
            { 
                throw;
            }
        }

        public static List<Allocation> FindPersonalsProjects(Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                        .Include("Project")
                        .Include("Developer")
                        .Where(a => a.Developer.Id == dev.Id)
                        .ToList();
                }

            }
            catch
            {
                throw;
            }
        }

        public static List<Allocation> GetAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                        .Include("Project")
                        .Include("Developer")
                        .ToList();
                }

            }
            catch
            {
                throw;
            }
        }
        public static void AddTask(Allocation aloc,Task task)
        {

            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Allocations.Attach(aloc);

                    aloc.Tasks.Add(task);

                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }

        }

        public static Allocation GetAllocationWTasksById(Int32 aloc)
        {

            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                        .Include("tasks")
                        .FirstOrDefault(a => a.Id == aloc);
                }
            }
            catch
            {
                throw;
            }

        }
        public static Allocation GetByProjectAndDev(Project proj, Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                       .Where(a => a.Project.Id == proj.Id && a.Developer.Id == dev.Id)
                       .FirstOrDefault();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Task> GetTask(Project proj, Developer dev)
        {

            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                       .Include("tasks")
                       .Where(a => a.Project.Id == proj.Id && a.Developer.Id == dev.Id)
                       .Select(a => a.Tasks)                       
                       .FirstOrDefault()
                       .ToList();
                }
            }
            catch
            {
                throw;
            }

        }

    }
}
