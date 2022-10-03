using DatabaseServices.Abstract;

namespace DatabaseServices.Concrete.Databases
{
    public class SqlServer : IDbService
    {
        public void CreateData() => Console.WriteLine("SqlServer => Create");

        public void DeleteData() => Console.WriteLine("SqlServer => Delete");

        public void ReadData() => Console.WriteLine("SqlServer => Read");

        public void UpdateData() => Console.WriteLine("SqlServer => Update");
    }
}
