using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class PhotoAlbumRepository : Repository<PhotoAlbum>, IPhotoAlbumRepository
    {
        public PhotoAlbumRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }

        public async Task<IEnumerable<PhotoAlbum>> GetAllPhotoAlbumsFromUser(long id)
        {
            var photoAlbums = await DbSet.ToListAsync();

            return photoAlbums.Where(x => x.ProfileId == id).ToList();
        }
    }
}
