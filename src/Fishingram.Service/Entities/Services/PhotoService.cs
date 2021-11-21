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
    public class PhotoService : ServiceBase<Photo>, IPhotoService
    {
        private readonly IPhotoRepository _repository;
        public PhotoService(IPhotoRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
