using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace LSM.Utilities
{
    class Configurations
    {
        private static IniData CONFIG { get; set; }
    
        public static void loadConfigs()
        {
            CONFIG = new FileIniDataParser().ReadFile("cfg.ini");
        }

        public static Models.Server Server()
        {
            if(CONFIG == null)
            {
                loadConfigs();
            }

            return new Models.Server(
            
                CONFIG["svr"]["host"],
                CONFIG["svr"]["port"],
                bool.Parse(CONFIG["svr"]["secured"]) ? "https" : "http"
            );

        }
    }
}
