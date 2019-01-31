using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Capgemini.Ams.Dojo.Comic.Api
{
    /// <summary>
    ///     Classe contenant le point d'entree du programme dotnet core
    /// </summary>
    public class Program
    {
        /// <summary>
        ///     Point d'entree standard pour une dll ou une application
        /// </summary>
        /// <param name="args">Tableau des arguments present en ligne de commande</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        ///     Configuration et initialisation du WebHost (serveur web = Kestrel dans notre cas) qui va porter l'API
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)

                .UseStartup<Startup>();
    }
}
