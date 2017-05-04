using System.Data.Entity;
using SmartRent.DataAccess;

namespace SmartRent.DataAccess
{
    public class DatabaseContextInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
