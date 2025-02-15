﻿using Fishingram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Repositories
{
    public interface IPhotoAlbumRepository : IRepository<PhotoAlbum>
    {
        Task<IEnumerable<PhotoAlbum>> GetAllPhotoAlbumsFromUser(long id);
    }
}
