using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ActorRazorPages.Models;

namespace ActorRazorPages.Pages.Actors
{
    public class IndexModel : PageModel
    {
        public IData _data;
        public IndexModel (IData data)
        {
            _data = data;
        }
        public IList<Actor> Actors { get; set; }
        public void OnGet()
        {
            Actors = _data.ActorsInitializeData();
        }
    }
}
