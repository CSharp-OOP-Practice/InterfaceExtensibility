namespace Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // In an ideal world we would like to design or software such that we can change its behavior without changing its code.
            // Using extensibility which means instead of changing the code in the existing classes simply add in new classes that change the behavior of the system.
            // The impact should be minimal to zero on the existing classes because we are not changing the existing code.

            //題目：使用同一個DbMigrator，切換不同的實體來執行不同的路。
            //var dbMigrate = new DbMigrator(new ConsoleLogger());
            var dbMigrate = new DbMigrator(new FileLogger(@"E:\C#\Extensibility\log.txt"));

            dbMigrate.Migrate();
        }
    }
}
