using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;

namespace GestaoDesenvolvedores
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        //public DbSet<Task> Tasks { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            // If database not exists, create it ...
            if (Database.CreateIfNotExists())
            {
                // ... and...
                Repository repositorio = this;

                // Insert Developer levels
                Level Pleno = new Level("Pleno");
                Level Junior = new Level("Júnior");
                Level Studiant = new Level("Estudante");
                Level Senior = new Level("Sênior");

                repositorio.Levels.Add(Senior);
                repositorio.Levels.Add(Pleno);
                repositorio.Levels.Add(Junior);
                repositorio.Levels.Add(Studiant);

                // ... insert a default administrator
                Developer defaultAdm = new Developer();
                defaultAdm.Name = "Admin";
                defaultAdm.BdayDate= DateTime.Now.Date;
                defaultAdm.Level = Senior;

                Credential defaultCredential = new Credential();
                defaultCredential.Password = "adminpass";
                defaultCredential.Email = "admin@default.com";
                defaultCredential.IsAdmin = true;
                defaultCredential.IsActive = true; 

                defaultCredential.Developer = defaultAdm;
                defaultAdm.Credential = defaultCredential;

                repositorio.Developers.Add(defaultAdm);


                // -- //
                repositorio.SaveChanges();
            }
        }

        public static MySqlConnection GetDbConnection()
        {
            if (_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["ProgVisConnectionString"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}
