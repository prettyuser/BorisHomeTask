using BorisHomeTask.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.DataLayer.DataSeed
{
    public interface IDataSeeder
    {
        void Seed(BorisHomeTaskContext context);
    }
}
