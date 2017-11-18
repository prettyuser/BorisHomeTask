using BorisHomeTask.DataLayer.Context.UnitOfWork;
using BorisHomeTask.Domain.Entities.Application;
using BorisHomeTask.Manager.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorisHomeTask.Repository;

namespace BorisHomeTask.Manager.Implementation
{
    public class WorkPlaceService : EntityService<WorkPlace>, IWorkPlaceService
    {
        IUnitOfWork _unitOfWork;
        IWorkPlaceRepository _workPlaceRepository;

        public WorkPlaceService (IUnitOfWork unitOfWork, IWorkPlaceRepository workPlaceRepository)
           : base(unitOfWork, workPlaceRepository)
       {
            _unitOfWork = unitOfWork;
            _workPlaceRepository = workPlaceRepository;
        }


        public WorkPlace GetById(int Id)
        {
            return _workPlaceRepository.GetById(Id);
        }
    }
}
