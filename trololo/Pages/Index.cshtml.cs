﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using trololo.Models;

namespace trololo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";

            }

        }
        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";

            }
            if (!ModelState.IsValid)
            {

                ViewData["a"] = FizzBuzz.CheckRange();
            }
            return Page();

        }
        


    }
}