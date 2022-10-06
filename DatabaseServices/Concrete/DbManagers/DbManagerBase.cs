using DatabaseServices.Abstract;

namespace DatabaseServices.Concrete.DatabaseManagers
{
    public class DbManagerBase : IDbManager
    {
        private readonly IDbService _databaseService;

        public DbManagerBase(IDbService databaseService)
        {
            _databaseService = databaseService;
        }

        public void Create() => _databaseService.CreateData();
        public void Read() => _databaseService.ReadData();
        public void Update() => _databaseService.UpdateData();
        public void Delete() => _databaseService.DeleteData();
    }
}
