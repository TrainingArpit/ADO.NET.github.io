using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Unity;

namespace PracADO.NET
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var container = DependencyConfig.RegisterComponents();
            var service = container.Resolve<IMessageService>();
            service.SendMessage("Arpit Is Here");
        }
    }
}
