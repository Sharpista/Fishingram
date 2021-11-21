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
    public class NotificationService : ServiceBase<Notification>, INotificationService
    {
        private readonly INotificationRepository _repository;
        public NotificationService(INotificationRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
