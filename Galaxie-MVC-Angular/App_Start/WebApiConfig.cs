using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace Galaxie_MVC_Angular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            // Web API configuration and services
            config.Routes.MapHttpRoute(
              name: "ApiUriPathExtension",
              routeTemplate: "api/{controller}.{ext}"
            );

            config.Routes.MapHttpRoute(
              name: "ApiUriPathExtension ID",
              routeTemplate: "api/{controller}/{id}.{ext}",
              defaults: new { id = RouteParameter.Optional }
            );



            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );




            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
