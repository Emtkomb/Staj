using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDo.EntityLayer.Concrete;
using WebUI.Models.Role;

namespace WebUI.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleAssignController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
            TempData["userid"] = user.Id;
            var roles=_roleManager.Roles.ToList();
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleASsignViewModel> roleASsignViewModels= new List<RoleASsignViewModel>();
            foreach(var item in roles)
            {
                RoleASsignViewModel model= new RoleASsignViewModel();
                model.RoleID= item.Id;
                model.RoleName= item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleASsignViewModels.Add(model);
            }
            return View(roleASsignViewModels);

        }
    }
}
