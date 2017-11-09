using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.DataLayer.Context.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
