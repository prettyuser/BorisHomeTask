using BorisHomeTask.Domain.Entities.Application;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BorisHomeTask.DataLayer.Context
{
    public class BorisHomeTaskContext : DbContext
    {
        public BorisHomeTaskContext()
        : base("Name=BorisHomeTaskContext")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}



    
