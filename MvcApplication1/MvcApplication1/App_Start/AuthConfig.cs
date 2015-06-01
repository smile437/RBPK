using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using MvcApplication1.Models;

namespace MvcApplication1
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            /*OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "aTzl56eVKELz92UgU14GMTZtt",
                consumerSecret: "eTnR3T6qHpqactc4NznlzDC00GVRCAZlo2SsgnbjuqbvlNI13v");*/

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "348203125389860",
                appSecret: "91266b230150b6bbad82e4bc41f94215");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
