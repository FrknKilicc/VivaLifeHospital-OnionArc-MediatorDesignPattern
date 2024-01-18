using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Services
{
    public static class ServiceRegistiration
    {
        public static void SaveAppServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
        }
    }
}
