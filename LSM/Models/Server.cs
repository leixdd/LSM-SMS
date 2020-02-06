using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Models
{
    class Server
    {
        public string host { get; set; }
        public string port { get; set; }
        public string secured { get; set; }

        public Server(string u_host, string u_port, string u_secured)
        {
            host = u_host;
            port = u_port;
            secured = u_secured;
        }

        
    }
}
