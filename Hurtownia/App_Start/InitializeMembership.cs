using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace Hurtownia.App_Start
{
    public static class InitializeMembership
    {
        public static void SeedMembership()
        {
            WebSecurity.InitializeDatabaseConnection("LocalConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
        }
    }
}