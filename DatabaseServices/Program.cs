 
using DatabaseServices.Abstract; 
using Microsoft.Extensions.DependencyInjection;
using DatabaseService.Containers.Autofac;
using DatabaseService.Containers.Microsoft;
using Autofac;

// .Net Core 6 DI Container
var containerMicrosoft = MicrosoftContainer.ConfigureService();
var dbManagerMicrosoft = containerMicrosoft.GetRequiredService<IDbManager>();

// Autofac DI Container
var containerAutofac = AutofacContainer.ConfigureService();
var dbManagerAutofac = containerAutofac.Resolve<IDbManager>(); 


List<IDbManager> dbManagers = new() { dbManagerMicrosoft, dbManagerAutofac };

dbManagers.ForEach(dbManager => 
{ 
    dbManager.Create(); 
    dbManager.Read(); 
    dbManager.Update(); 
    dbManager.Delete();
    Console.WriteLine("=============");
});



Console.ReadKey(); 


