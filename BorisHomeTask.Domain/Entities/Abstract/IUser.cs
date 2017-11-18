using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorisHomeTask.Domain.Entities.Application;

namespace BorisHomeTask.Domain.Entities.Abstract
{
    public interface IUser
    {
        string Name { get; set; }

        ICollection<WorkPlace> WorkPlaces { get; set; }
    }
}
