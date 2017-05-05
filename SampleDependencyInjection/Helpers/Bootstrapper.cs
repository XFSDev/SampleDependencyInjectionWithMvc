using System.Web.Mvc;
using Microsoft.Practices.Unity;
using SampleDependencyInjection.Models;
using Unity.Mvc4;

namespace SampleDependencyInjection.Helpers
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductRepository, ProductRepository>();

            RegisterTypes(container);

            return container;
        }

        private static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}