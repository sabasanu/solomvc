using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Solo_MVC.Pages.Components.About
{
    [ViewComponent(Name = "About")]
    public class AboutViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}