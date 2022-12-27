using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VefatcomAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                //database bağlanmak için klasör seçimi.
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/VefatcomAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MsSql");


            }
        }
    }
}
