﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Domain.Contract
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
