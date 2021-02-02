using Domain.Interface;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IoC
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {

            //services.AddScoped<IDesenvolvedorService, DesenvolvedorService>();
            //services.AddScoped<IDesenvolvedorService, DesenvolvedorService>();
            //services.AddScoped<IDesenvolvedorService, DesenvolvedorService>();

            services.AddScoped<IDesenvolvedorRepository, DesenvolvedorRepository>();
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<ILancamentoHoraRepository, LancamentoHoraRepository>();

        }
    }
}
