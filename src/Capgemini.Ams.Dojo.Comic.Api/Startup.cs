namespace Capgemini.Ams.Dojo.Comic.Api
{
    using System;
    using Capgemini.Ams.Dojo.Comic.Business;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Swashbuckle.AspNetCore.Swagger;

    /// <summary>
    ///     Classe de configuration de l'API appelee au runtime lors de l'initialisation de l'application
    /// </summary>
    public class Startup
    {
        /// <summary>
        ///     ctor of <see cref="Startup"/>
        /// </summary>
        /// <param name="configuration">Injection de Dependance : Classe native de gestion des parametres</param>
        public Startup(IConfiguration configuration)
            => this.Configuration = configuration;

        /// <summary>
        ///     Reference du controlleur de parametres pour l'application
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to add services to the container
        /// </summary>
        /// <param name="services">Collection contenant la description de l'ensemble des services disponible pour l'application</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBusiness();

            // Ajout du service en charge de la gestion du cache
            services.AddResponseCaching();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        /// <summary>
        ///     This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">Fournit la mecaniaue de controle permettant de configurer le pipeline des requetes vers l'API</param>
        /// <param name="env">Fournit les informations concernant l'environnement d'execution de l'application</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Ajout de la redirection HTTPS automatique
            app.UseHttpsRedirection();

            // Ajout du middleware responsable de la gestion du cache dans le pipeline d'execution
            app.UseResponseCaching();

            app.UseMvc();
        }
    }
}
