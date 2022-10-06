﻿using ItFoxTecWebFormThree.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ItFoxTecWebFormThree
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            IdentityConfig.RegisterIdentity();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        //void Session_Start(object sender, EventArgs e)
        //{
        //    // Code that runs when a new session is started

        //    Response.Redirect("~/Default.aspx");

        //}
    }
}