using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Solo_MVC.Pages.Components.Services
{
    public class ServicesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}