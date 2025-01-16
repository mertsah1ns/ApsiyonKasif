using ApsiyonKasif.Core.Repositories;
using ApsiyonKasif.Core.Services;
using ApsiyonKasif.Core.UnitOfWork;
using ApsiyonKasif.Repository.Context;
using ApsiyonKasif.Repository.Repositories;
using ApsiyonKasif.Repository.UnitOfWork;
using ApsiyonKasif.Service.Services;
using Autofac;
using Module = Autofac.Module;
using System.Reflection;

namespace ApsionKasif.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();


            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext))!;
            var serviceAssembly = Assembly.GetAssembly(typeof(IGenericService<>))!;

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
