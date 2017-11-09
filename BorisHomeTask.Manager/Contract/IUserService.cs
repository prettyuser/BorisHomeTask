using BorisHomeTask.Domain.Entities.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Manager.Contract
{
    public interface IUserService : IEntityService<User>
    {
        User GetById(long Id);
    }
}
