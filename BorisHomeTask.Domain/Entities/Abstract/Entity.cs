﻿using BorisHomeTask.Domain.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorisHomeTask.Domain.Entities.Abstract
{
    public abstract class BaseEntity
    {

    }
    
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
    }
}