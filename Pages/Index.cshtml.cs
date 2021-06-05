using AppRunnerTestWebApplication.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppRunnerTestWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly string applicationName;

        public IndexModel(ILogger<IndexModel> logger, IOptionsMonitor<ApplicationOptions> applicationOptionsMonitor)
        {
            _logger = logger;
            applicationName = applicationOptionsMonitor?.CurrentValue?.ApplicationName ?? "default name";
        }

        public void OnGet()
        {

        }
    }
}
