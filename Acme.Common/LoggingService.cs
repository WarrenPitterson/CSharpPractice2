using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTests
{
    public static class LoggingService
    {
        public static void WritetoFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
            Console.WriteLine(item.Log());
            }
        }
    }
}
