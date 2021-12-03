using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Service.Entities.Services
{
    public class PhotoAlbumService : ServiceBase<PhotoAlbum>, IPhotoAlbumService
    {
        private readonly IPhotoAlbumRepository _photoAlbumRepository;
        public PhotoAlbumService(IPhotoAlbumRepository repository) : base(repository)
        {
            _photoAlbumRepository = repository;
        }
    }
}
