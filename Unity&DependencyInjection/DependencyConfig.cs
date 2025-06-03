using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace PracADO.NET
{
    public class DependencyConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IMessageService, EmailService>();
            return container;
        }

    }
}
