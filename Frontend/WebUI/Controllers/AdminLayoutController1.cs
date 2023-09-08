using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;

namespace WebUI.Controllers
{
    public class AdminLayoutController1 : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult PreLoaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }


    }
}
