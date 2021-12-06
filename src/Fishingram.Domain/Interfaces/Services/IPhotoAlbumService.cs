using Fishingram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Services
{
    public interface IPhotoAlbumService : IServiceBase<PhotoAlbum>
    {
        Task<IEnumerable<PhotoAlbum>> GetPhotoAlbumsFromUser(long id);
    }
}
