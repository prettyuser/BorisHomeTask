using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BorisHomeTask.DataLayer.Context;
using BorisHomeTask.Domain.Entities.Application;

namespace BorisHomeTask.DataLayer.DataSeed
{
    internal class DataSeeder : IDataSeeder
    {
        public void Seed(BorisHomeTaskContext context)
        {
            var users = new List<User>
            {
            //new User{  FirstName="Ark",LastName="Roop",JoiningDate=DateTime.Parse("2005-09-01")},
            //new User{FirstName="Akash",LastName="Gupta",JoiningDate=DateTime.Parse("2002-09-01")},
            //new User{FirstName="Saurabh",LastName="Gupta",JoiningDate=DateTime.Parse("2003-09-01")},

            };
            //users.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var workPlaces = new List<WorkPlace>
            {
            //new WorkPlace{UserId=1,DepartmentID=1,Band=Convert.ToDecimal(2.00)},
            //new WorkPlace{EmployeeID=2,DepartmentID=1,Band=Convert.ToDecimal(3.00)},
            //new WorkPlace{EmployeeID=3,DepartmentID=2,Band=Convert.ToDecimal(4.00)},

            };
            //workPlaces.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
