using Autofac;
using EorzeanFisher.Services.Dialog;
using EorzeanFisher.Services.Navigation;
using EorzeanFisher.Services.Preferences;
using EorzeanFisher.ViewModel.Guide;
using EorzeanFisher.ViewModel.Guide.Dungeons;
using EorzeanFisher.ViewModel.Popup;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.ViewModel.Base
{
    public class Locator
    {
        Autofac.IContainer container;
        ContainerBuilder containerBuilder;

        public static Locator Instance { get; } = new Locator();

        public Locator()
        {
            containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<DialogService>().As<IDialogService>();
            containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            containerBuilder.RegisterType<PreferenceService>().As<IPreferenceService>();
            containerBuilder.RegisterType<MainViewModel>();

            // Popup
            containerBuilder.RegisterType<LoadingViewModel>();

            // Guide
            containerBuilder.RegisterType<MainGuideViewModel>();
            containerBuilder.RegisterType<DungeonListViewModel>();
            containerBuilder.RegisterType<DungeonDetailViewModel>();

        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface => containerBuilder.RegisterType<TImplementation>().As<TInterface>();

        public void Register<T>() where T : class => containerBuilder.RegisterType<T>();

        public void Build() => container = containerBuilder.Build();
    }
}
