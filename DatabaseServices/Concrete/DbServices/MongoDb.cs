using DatabaseServices.Abstract;

namespace DatabaseServices.Concrete.Databases
{
    public class MongoDb : IDbService
    {
        public void CreateData() => Console.WriteLine("MongoDb => Create");

        public void DeleteData() => Console.WriteLine("MongoDb => Delete");

        public void ReadData() => Console.WriteLine("MongoDb => Read");

        public void UpdateData() => Console.WriteLine("MongoDb => Update"); 
    }
}
