using System.Web.Http;
using System.Web.Http.Cors;

namespace MWebApi
{
    public static class WebApiConfig
    {
         public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            //Configuración para verificar la seguridad del CORS
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
