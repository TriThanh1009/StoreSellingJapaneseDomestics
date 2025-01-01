using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataAccess
{
    public class DataServer
    {
        public string ServerName { get; set; } = "Host=172.19.0.3, Host=5432;Database=ssjddb;Username=root;Password=root";
    }
}
