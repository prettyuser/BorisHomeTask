using BorisHomeTask.DataLayer.Context;
using BorisHomeTask.DataLayer.DataSeed;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BorisHomeTask.DataLayer.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<BorisHomeTaskContext>
    {
        private bool _isDatabaseSeeded;

        public static IList<IDataSeeder> Seeders { get; private set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;


            // Add defaults seeders
            // ReSharper disable once UseObjectOrCollectionInitializer
            Seeders = new List<IDataSeeder>();

#if DEBUG
            Seeders.Add(new DataSeeder());
#endif
        }

        internal void SeedDatabase(BorisHomeTaskContext context)
        {
            if (!_isDatabaseSeeded)
            {
                Seed(context);
                _isDatabaseSeeded = true;
            }
        }

        protected override void Seed(BorisHomeTaskContext context)
        {
            System.Diagnostics.Debugger.Launch();
//#if DEBUG
//            if (System.Diagnostics.Debugger.IsAttached == false)
//            {
//                System.Diagnostics.Debugger.Launch();
//            }
//#endif
//            var updater = new SchemaDescriptionUpdater<BorisHomeTaskContext>(context);
//            updater.UpdateDatabaseDescriptions();
        }

        
        public void FixEfProviderServicesProblem()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }
    }
}
