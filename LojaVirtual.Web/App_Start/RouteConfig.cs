using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,
                            "",
                            new
                            {
                                controller = "Produto",
                                action = "ListarProdutos",
                                categoria = (string)null,
                                pagina = 1
                            });

            //Inicio
            routes.MapRoute(null,
                           "Pagina{pagina}",
                           new
                           {
                               controller = "Produto",
                               action = "ListarProdutos",
                               categoria = (string)null,
                               pagina = 1
                           });
            // 2
            routes.MapRoute(null,
                              "pagina{pagina}",
                              new
                              {
                                  controller = "Produto",
                                  action = "ListarProdutos",
                                  categoria = (string)null,
                              },
                              new
                              {
                                  pagina = @"\d+"
                              }
                          );



            //3
            routes.MapRoute(null, "{categoria}", new
            {
                controller = "Produto",
                action = "ListarProdutos",
                pagina = 1
            });

            //4
            routes.MapRoute(null,
                             "{categoria}/pagina{pagina}",
                             new
                             {
                                 controller = "Produto",
                                 action = "ListarProdutos"
                             },
                             new
                             {
                                 pagina = @"\d+"
                             }
                         );

            routes.MapRoute(null, "{controller}/{action}");
   

        }
    }
}
