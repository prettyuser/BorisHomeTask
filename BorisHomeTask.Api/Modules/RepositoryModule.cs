using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;

namespace BorisHomeTask.Api.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("BorisHomeTask.Repository"))
                       .Where(t => t.Name.EndsWith("Repository"))
                       .AsImplementedInterfaces()
                       .AsSelf()
                       .InstancePerRequest();
        }
    }
}