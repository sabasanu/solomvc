using Microsoft.AspNetCore.Mvc;

namespace Solo_MVC.Pages.Components.Team
{
    public class TeamViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}