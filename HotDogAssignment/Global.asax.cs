using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using HotDogAssignment.Models;

namespace HotDogAssignment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            seed();
            
        }
        private void seed()
        {
            HotDogLover StartDog = new HotDogLover()
            {
                ProfilePic = "http://i.imgur.com/ply5VI0.jpg",
                FavoriteDog = "Chorizo",
                LastDog = "Chili Dog",
                Date = new DateTime(2015, 3, 14),
                Name = "James Schroeder",
                Bio = "I've had hot dogs for a long time.  They're pretty great I guess.  I used to only like ketchup and mustard only on mine, but now I like onions, fancy mustards, some kinds of relish, and whatever sounds good at the time.  I'm probably talking too much about hot dogs right now.  Oh well.",
                HotDogs = new List<string>() { "Lonnie's Chicago Dog (2/23/15)" , "Ollie's Trolley Hot Dog (2/10/15)"}
            };
            
            Profiles.Profile.Add(StartDog);
        }
    }
}
