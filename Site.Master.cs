﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace SportsPro
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            ContextBoundObject.GetOwinContext().Authentication.Signout(DefaultAuthenticationTypes.ApplicationCookie);
        }
    }
}