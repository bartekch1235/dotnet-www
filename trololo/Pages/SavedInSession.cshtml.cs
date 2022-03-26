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
        public ListFizzBuzz FizzBuzzList = new ListFizzBuzz();
        public void OnGet()
        {
            var Data2 = HttpContext.Session.GetString("Data2");
            if (Data2 != null)
                FizzBuzzList = JsonConvert.DeserializeObject<ListFizzBuzz>(Data2);
            HttpContext.Session.SetString("Data2",JsonConvert.SerializeObject(FizzBuzzList));
        }
    }
}
