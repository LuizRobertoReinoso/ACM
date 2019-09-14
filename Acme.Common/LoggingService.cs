using System;
using System.Collections.Generic;

namespace Acme.Common
{
    public static class LoggingService
    {

        public static void WriteToFile(IList<ILoggable> itemsToLog) 
        {
            foreach (var item in itemsToLog)
                Console.WriteLine(item.Log());
        }
    }
}
