using Copa.Application.Application;
using Copa.Application.Contracts;
using Copa.Domain.Contracts.Services;
using Copa.Domain.ServiceDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Copa.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICopaApplication, CopaApplication>();

            services.AddScoped<ICopaServiceDomain, CopaServiceDomain>();
        }
    }
}
