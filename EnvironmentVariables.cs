using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DbUserManagement
{
    public static class EnvironmentVariables
    {
        public static string DefaultDatabase => ConfigurationManager.AppSettings.Get("defaultDatabase");
        public static string DefaultServer => ConfigurationManager.AppSettings.Get("defaultServer");
        public static string DefaultServerUser => ConfigurationManager.AppSettings.Get("defaultServerUser");
        public static string DefaultServerPwd => ConfigurationManager.AppSettings.Get("defaultServerPwd");
    }
}
