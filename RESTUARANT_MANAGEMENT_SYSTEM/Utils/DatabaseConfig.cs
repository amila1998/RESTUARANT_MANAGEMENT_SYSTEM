using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTUARANT_MANAGEMENT_SYSTEM.Utils
{
    public static class DatabaseConfig
    {
        public static string ConnectionString { get; } = "server=localhost;database=rms_db;uid=root;pwd=root;";
    }
}
