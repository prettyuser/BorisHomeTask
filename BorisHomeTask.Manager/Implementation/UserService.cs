using BorisHomeTask.DataLayer.Context.UnitOfWork;
using BorisHomeTask.Domain.Entities.Application;
using BorisHomeTask.Manager.Contract;
using BorisHomeTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Manager.Implementation
{
    public class UserService : EntityService<User>, IUserService
    {
        IUnitOfWork _unitOfWork;
        IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
          : base(unitOfWork, userRepository)
      {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }


        public User GetById(int Id)
        {
            return _userRepository.GetById(Id);
        }
    }
}
