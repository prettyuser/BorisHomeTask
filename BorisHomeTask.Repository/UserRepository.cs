using BorisHomeTask.Domain.Entities.Application;
using BorisHomeTask.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
            : base(context)
        {
        }

        public override IEnumerable<User> GetAll()
        {
            return _entities.Set<User>().AsEnumerable();
        }

        public User GetById(long id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
