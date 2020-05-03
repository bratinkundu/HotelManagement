using System.Web.Http;
using Unity;
using Unity.WebApi;
using HotelManagement_BL;
using HotelManagement_BL.Interface;
using HotelManagement_BL.Services;


namespace HotelManagement
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IBLHotel, HotelBL>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
            
        }
    }
}