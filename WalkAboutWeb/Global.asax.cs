using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WalkAboutWeb.Models;

namespace WalkAboutWeb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            BundleTable.Bundles.RegisterTemplateBundles();

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
         


            //these are only good for testing, so we can write a custom one that wroks better especially when we have data              in our tables, or we could just comment this section out and manually update the database schema.

            //use here when running on appharbor
            //Database.SetInitializer<WalkAboutDb>(new          Devtalk.EF.CodeFirst.DontDropDbJustCreateTablesIfModelChanged<WalkAboutDb>());
            



            //this doesnt work on appharbour, it will delete the database once the code in the model class is changes and the Database Schema needs updating, so you guys can use which one is more appropriate for testing.
            //My suggestion is that you use this initially to generate the database, simple change the connection 
            //string in web config and it will generat the dbase on first run.
            //since we may change the schema, this can be later removed and we manually add the changes to the dbase in management studio.

            //Database.SetInitializer<WalkAboutDb>
            //(new DropCreateDatabaseAlways<WalkAboutDb>());

           //another way to do it
            Database.SetInitializer<WalkAboutDb>(new DropCreateDatabaseIfModelChanges<WalkAboutDb>());

            //another way to do it
           //Database.SetInitializer<WalkAboutDb>(null);


        }
    }
}