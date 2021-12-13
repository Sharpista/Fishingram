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
            CreateMap<UserProfile, ProfileDTO>().ReverseMap();
            CreateMap<Post, PostDTO>().ReverseMap();
            CreateMap<PhotoAlbum, PhotoAlbumDTO>().ReverseMap();
            CreateMap<Photo, PhotoDTO>().ReverseMap();
            CreateMap<Follow, FollowDTO>().ReverseMap();
            CreateMap<UserProfile, LoginDTO>().ReverseMap();
        }
    }
}
