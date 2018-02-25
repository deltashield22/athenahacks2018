using AthenaHacks18.Data;
using AthenaHacks18.Data.Providers;
using AthenaHacks18.Services;
using AthenaHacks18.Web.Core.Services;
using System.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.WebApi;


namespace AthenaHacks18.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            
            container.RegisterType<IWordsService, WordsService>();
            container.RegisterType<IAuthenticationService, OwinAuthenticationService>();
            container.RegisterType<IDataProvider, SqlDataProvider>(
               new InjectionConstructor(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            //container.RegisterType<IPrincipal>(new TransientLifetimeManager(),
            //         new InjectionFactory(con => HttpContext.Current.User));


            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }
    }
}