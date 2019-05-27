using AbstractAccountApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi
{
    internal static class Error
    {
        internal static ILog log;

        internal static void AddError(string error)
        {
            if (log != null)
            {
                log.AddError(Origin.Google, error);
            }
            else
            {
                Debug.WriteLine("Google API Error: " + error);
            }
        }

        internal static void AddMessage(string message)
        {
            if (log != null)
            {
                log.AddMessage(Origin.Google, message);
            }
            else
            {
                Debug.WriteLine("Google API Message: " + message);
            }
        }
    }
}
