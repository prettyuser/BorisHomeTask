using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Domain.Entities.Abstract
{
    public interface IWorkPlace
    {
        string CompanyName { get; set; }

        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }
    }
}
