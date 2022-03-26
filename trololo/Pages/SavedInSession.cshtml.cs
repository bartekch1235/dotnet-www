using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using trololo.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace trololo.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                FizzBuzz =JsonConvert.DeserializeObject<FizzBuzz>(Data);
        }
    }
}
