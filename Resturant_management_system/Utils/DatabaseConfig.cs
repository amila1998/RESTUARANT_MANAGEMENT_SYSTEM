using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_management_system.Utils
{
    public class DatabaseConfig
    {
        public static string ConnectionString { get; } = "server=localhost;database=rms_db;uid=root;pwd=root;";
    }
}
