using Calculator.Services;
using Microsoft.Practices.Unity;
using Calculator.ViewModel;

namespace Calculator.Shared.Bootstrap
{
    /// <summary>
    /// Singleton Dependency Injection Container
    /// </summary>
    public static class Container
    {
        /// <summary>
        /// Initializes the <see cref="Container"/> class.
        /// </summary>
        static Container()
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