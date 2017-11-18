using BorisHomeTask.Domain.Entities.Application;
using BorisHomeTask.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetById(int id);
    }
}
