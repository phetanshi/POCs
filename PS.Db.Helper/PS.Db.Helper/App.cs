using Microsoft.Extensions.Configuration;
using PS.Db.Helper.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Db.Helper
{
    internal class App
    {
        private readonly IDatabaseRepo databaseRepo;
        public App(IDatabaseRepo databaseRepo)
        {
            this.databaseRepo = databaseRepo;
        }

        public void Run()
        {
            databaseRepo.GetSchema("test");
        }
    }
}
