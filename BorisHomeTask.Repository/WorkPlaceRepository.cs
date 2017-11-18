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
    public class WorkPlaceRepository : GenericRepository<WorkPlace>, IWorkPlaceRepository
    {
        public WorkPlaceRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<WorkPlace> GetAll()
        {
            return _entities.Set<WorkPlace>().Include(x => x.User).AsEnumerable();
        }

        public WorkPlace GetById(int id)
        {
            return _dbset.Include(x => x.User).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
