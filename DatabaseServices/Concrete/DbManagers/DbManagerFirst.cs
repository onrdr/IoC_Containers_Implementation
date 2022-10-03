
using DatabaseServices.Abstract;

namespace DatabaseServices.Concrete.DatabaseManagers
{
    public class DbManagerFirst : DbManagerBase
    {
        public DbManagerFirst(IDbService databaseService): base(databaseService)
        {

        }
    }
}
