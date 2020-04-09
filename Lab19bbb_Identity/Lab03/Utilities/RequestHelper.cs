using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03.Utilities
{
    /// <summary>
    /// 
    /// This code is a copy from The solution provided by the teacher for lecture 19 about identity and authentication and is code the teacher copied from:
    /// https://stackoverflow.com/questions/43138659/request-isajaxrequest-alternative-in-mvc6
    /// </summary>
    internal static class RequestHelper
    {
        internal static bool IsAjaxRequest(this HttpRequest request)
        {
            return string.Equals(request.Query["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal) ||
                string.Equals(request.Headers["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal) ||
                string.Equals(request.Headers["X-Requested-With"], "Fetch", StringComparison.Ordinal);
        }
    }
}
