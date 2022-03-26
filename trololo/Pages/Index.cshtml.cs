using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using trololo.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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
        

        public ListFizzBuzz FizzBuzzList =new ListFizzBuzz();

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public void OnGet()
        {
            var Data2 = HttpContext.Session.GetString("Data2");
            if (Data2 != null)
                FizzBuzzList = JsonConvert.DeserializeObject<ListFizzBuzz>(Data2);
            
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";

            }

        }
        public IActionResult OnPost()
        {
            var Data2 = HttpContext.Session.GetString("Data2");
            if (Data2 != null)
                FizzBuzzList = JsonConvert.DeserializeObject<ListFizzBuzz>(Data2);


            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";

            }

            if (FizzBuzz.Check())
            {
                FizzBuzzList.add(FizzBuzz);
                HttpContext.Session.SetString("Data2",JsonConvert.SerializeObject(FizzBuzzList));
                return RedirectToPage("./SavedInSession");
            }
            ViewData["a"] = FizzBuzz.CheckRange();
            return Page();//RedirectToPage("./SavedInSession");
        }



    }
}