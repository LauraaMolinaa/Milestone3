using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HPlusSport.Security.identity.Pages
{
    [Authorize]
    public class PriviledgedModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
