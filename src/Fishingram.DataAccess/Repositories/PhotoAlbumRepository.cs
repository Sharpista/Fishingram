using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class PhotoAlbumRepository : Repository<PhotoAlbum>, IPhotoAlbumRepository
    {
        public PhotoAlbumRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }
    }
}
