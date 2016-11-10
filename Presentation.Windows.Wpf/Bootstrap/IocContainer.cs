using Microsoft.Practices.Unity;
using OrderWise.Calculator.Application.Core;
using OrderWise.Calculator.Application.Services;
using OrderWise.Calculator.Presentation.CommonXaml.ViewModel;

namespace OrderWise.Calculator.Presentation.WinApp.Wpf.Bootstrap
{
    /// <summary>
    /// Singleton Dependency Injection Container
    /// </summary>
    public static class IocContainer
    {
        /// <summary>
        /// Initializes the <see cref="IocContainer"/> class.
        /// </summary>
        static IocContainer()
        {
            RegisterTypes();
        }

        /// <summary>
        /// Get the current configured container
        /// </summary>
        /// <returns>Configured container</returns>
        public static IUnityContainer Current { get; private set; }

        private static void RegisterTypes()
        {
            Current = new UnityContainer();

            // register services
            Current.RegisterType<ICalculateService, CalculateService>(new ContainerControlledLifetimeManager());

            // register models

            // register view models
            Current.RegisterType<CalculatorViewModel>(new TransientLifetimeManager());

            // register views
        }
        
    }
}