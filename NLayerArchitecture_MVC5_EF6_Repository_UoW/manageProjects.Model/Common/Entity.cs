﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manageProjects.Model
{
    public abstract class BaseEntity { 
    
    }

    public abstract class Entity<T> : BaseEntity, IEntity<T> 
    {
        //public virtual T Id { get; set; }
    }
}
