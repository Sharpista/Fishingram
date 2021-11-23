using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserProfile, ProfileDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<PhotoAlbum, PhotoAlbumDTO>().ReverseMap();
            CreateMap<Photo, PhotoDTO>().ReverseMap();
            CreateMap<Notification, NotificationDTO>().ReverseMap();
        }
    }
}
