using DatabaseServices.Abstract;
using DatabaseServices.Concrete.DatabaseManagers;
using DatabaseServices.Concrete.Databases;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseService.Containers.Microsoft
{
    public class MicrosoftContainer
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IDbManager, DbManagerFirst>()
                .AddSingleton<IDbService, SqlServer>()
                .BuildServiceProvider();

            return provider;
        }
    }
}
