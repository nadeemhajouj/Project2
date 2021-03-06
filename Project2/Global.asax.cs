﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using Project2.Models;
using Project2.Logic;

namespace Project2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Initialize the Database
            Database.SetInitializer(new CourseDatabaseInitializer());

            // Create the administrator role and user.
            RoleActions roleActions = new RoleActions();
            roleActions.createAdmin();
            roleActions.createStudent();
            roleActions.createTeacher();
        }
    }
}