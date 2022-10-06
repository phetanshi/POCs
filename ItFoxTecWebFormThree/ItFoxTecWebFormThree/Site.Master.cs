using ItFoxTecWebFormThree.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;

namespace ItFoxTecWebFormThree
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.IsAuthenticated)
            {
                var displayNameClaim = ClaimsPrincipal.Current.FindFirst(SamlClaimTypes.DisplayName);
                LoginUserName.InnerText = displayNameClaim != null ? displayNameClaim.Value : "<No Name>";
            }
            else
            {
                Response.Redirect("/Auth/Login");
            }
            
        }
    }
}