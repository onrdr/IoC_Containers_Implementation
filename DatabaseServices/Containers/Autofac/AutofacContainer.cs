
using Autofac;
using DatabaseServices.Abstract;
using DatabaseServices.Concrete.DatabaseManagers;
using DatabaseServices.Concrete.Databases;

namespace DatabaseService.Containers.Autofac
{
    public class AutofacContainer
    {
        public static IContainer ConfigureService()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<DbManagerFirst>().As<IDbManager>();
            builder.RegisterType<SqlServer>().As<IDbService>();
            return builder.Build();

        }
    }
}
