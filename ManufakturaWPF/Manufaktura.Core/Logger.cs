using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Manufaktura.Core
{
    public static class Logger
    {
        public static void LogDebug(string log)
        {
            Debug.WriteLine(log);
        }
    }
}
