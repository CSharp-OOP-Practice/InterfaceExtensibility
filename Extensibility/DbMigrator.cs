using System;

namespace Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logeer;

        public DbMigrator(ILogger logger)
        {
            _logeer = logger;
        }

        public void Migrate()
        {
            _logeer.LogError("Migration started at " + DateTime.Now);
            _logeer.LogInfo("Migration finished at " + DateTime.Now);
        }

        //有個問題，如果未來改成用File或其他方式，這段code就沒用了。所以改用interface
        // 這個方式，只用在未來可能使用其他方式取代的可能性很高的請況下使用。
        public void MigrateOriginal()
        {
            Console.WriteLine("Migration started at {0}", DateTime.Now);

            //Details of migrating the database.

            Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}
