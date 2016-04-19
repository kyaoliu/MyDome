using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AutoFac
{
    public class DIContainer
    {
        static Autofac.IContainer _container;

        public static void RegisterBuilder(ContainerBuilder builder)
        {
            _container = builder.Build();
        }

        public static T Resolve<T>()
        {
            using (ILifetimeScope lifetime = _container.BeginLifetimeScope())
            {
                return lifetime.Resolve<T>();
            }
        }

    }
}
