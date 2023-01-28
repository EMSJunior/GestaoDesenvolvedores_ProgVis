using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDesenvolvedores
{
    internal class LevelsRepository
    {          
        public static List<Level> GetLevels()
        {
            try
            {
                using (Repository DbContext = new Repository())
                {
                    return DbContext.Levels.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Level GetLevel(Level Level)
        {
            try
            {
                using (Repository DbContext = new Repository())
                { 
                    return DbContext.Levels.Find(Level.Id);
                }

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
