using Fishingram.DataAccess.Context;
using Fishingram.DataAccess.Repositories;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Fishingram.Service.Entities.Services;
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
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IPhotoAlbumRepository, PhotoAlbumRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IFollowRepository, FollowRepository>();

            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IPhotoAlbumService, PhotoAlbumService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IFollowService, FollowService>();

            return services;
        }
    }
}
