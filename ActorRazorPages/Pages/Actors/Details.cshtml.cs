using ActorRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ActorRazorPages.Models;

namespace ActorRazorPages.Pages.Actors
{
    public class DetailsModel : PageModel
    {
        private IData _data;
        public DetailsModel(IData data)
        {
            _data = data;
        }
        public Actor Actor { get; set; }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
                return NotFound();

            Actor = _data.GetActorById(id);

            if (Actor == null)
                return NotFound();

            return Page();
        }
    }
}
