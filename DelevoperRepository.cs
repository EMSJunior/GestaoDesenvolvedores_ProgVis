using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoDesenvolvedores
{
    internal class DeveloperRepository
    {
        public static void Save(Developer dev)
        {
            //try
            //{
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(dev.Level).State = EntityState.Unchanged;

                    if (dev.Id == 0)
                    {
                        dbContext.Developers.Add(dev);
                    }
                    else
                    {
                        dbContext.Entry(dev.Credential).State = EntityState.Modified;
                        dbContext.Entry(dev.Level).State = EntityState.Modified;
                        


                        dbContext.Developers.Attach(dev);
                    }
                    dbContext.SaveChanges();
                    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
       

        public static List<Developer> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Developer> FindAllWCredential()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("credential").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Developer FindById(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Find(id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Developer FindByIdWCredential(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Include("credential")
                        .Where(u => u.Id == id)
                        .Include("Level")
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Developer FindByEmailWCredential(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Include("Credential")
                        .Where(e => e.Credential.Email == email)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Developer> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Where(u => u.Name.Contains(partialName))
                        .ToList<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Developer> FindByPartialNameWCredential(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers
                        .Include("Credential")
                        .Where(u => u.Name.Contains(partialName))
                        .ToList<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static void Remove(Developer dev)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Developers.Attach(dev);
                    dbContext.Developers.Remove(dev);

                    // OR

                    // But cascade delete fails...
                    //dbContext.Entry(usuario).State
                    //    = EntityState.Deleted;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        
        public static bool Check(Developer dev)
        {
            try
            {
                using (Repository Dbcontext = new Repository())
                {
                    return Dbcontext.Developers.Any(e => e.Credential.Email == dev.Credential.Email);
                }
            }
            catch(Exception) { throw; }
        }
    }
}
