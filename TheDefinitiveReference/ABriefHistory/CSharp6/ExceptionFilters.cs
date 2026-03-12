using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ABriefHistory.CSharp6
{
    internal class ExceptionFilters
    {
        public static async Task Run()
        {
            string html;
            try
            {
                html = await new HttpClient().GetStringAsync("http://asef");
            }    
            // Let you apply condition to a catch block
            catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
            }
        }
    }
}
