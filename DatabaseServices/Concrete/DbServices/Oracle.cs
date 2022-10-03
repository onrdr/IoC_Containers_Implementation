using DatabaseServices.Abstract;

namespace DatabaseServices.Concrete.Databases
{
    public class Oracle : IDbService
    {
        public void CreateData() => Console.WriteLine("Oracle => Create");

        public void DeleteData() => Console.WriteLine("Oracle => Delete");

        public void ReadData() => Console.WriteLine("Oracle => Read");

        public void UpdateData() => Console.WriteLine("Oracle => Update");
    }
}
