using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Tractors.Layouts;

namespace Tractors.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;
        private readonly LayoutsService layoutsService;

        public IndexModel (
            ILogger<IndexModel> logger,
            LayoutsService layoutsService
        ) {
            this.layoutsService = layoutsService;
            _logger = logger;
        }

        public ILayout utm_content { get; private set; }

        public void OnGet (string utm_content) {
            this.utm_content = layoutsService.FindLayout(utm_content ?? "");
        }
    }
}