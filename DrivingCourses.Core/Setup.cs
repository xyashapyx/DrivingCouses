using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace DrivingCourses.Core
{
    public class Setup : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Factory")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterStorage();

            CreatableTypes()
                .EndingWith("Repository")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Replicator")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            ConfigurationManager.Init(this);

            Mvx.IoCProvider.RegisterSingleton(() => CrossConnectivity.Current);
            Mvx.IoCProvider.RegisterSingleton(() => UserDialogs.Instance);

            Mvx.IoCProvider.ConstructAndRegisterSingleton<IConnectionService, ConnectionService>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IDialogManager, DialogManager>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<ILoggedMethodRunner, LoggedMethodRunner>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IApiManager, ApiManager>();
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IStartupUpdater, StartupUpdater>();

            RegisterCustomAppStart<CoreAppStart>();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<LocationViewModel, LocationViewModel>();
                cfg.CreateMap<ImplicatedPersonViewModel, ImplicatedPersonViewModel>();
                cfg.CreateMap<TicketsFilterViewModel, TicketsFilterViewModel>();
            });

        }

        private void RegisterStorage()
        {
            //Storage
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISqliteStorage, SqliteStorage>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISqliteBlobStorage, SqliteBlobStorage>();
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<IDataUpgrade, DataUpgrade>();
        }
    }
}
