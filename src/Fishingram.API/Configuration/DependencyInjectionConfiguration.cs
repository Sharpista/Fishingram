using Fishingram.DataAccess.Context;
using Fishingram.DataAccess.Repositories;
using Fishingram.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.Configuration
{
    public static  class DependencyInjectionConfiguration
    {
        public static IServiceCollection DependencyResolvers(this IServiceCollection services)
        {
            services.AddScoped<FishingramContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IPhotoAlbumRepository, PhotoAlbumRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();

            return services;
        }
    }
}
