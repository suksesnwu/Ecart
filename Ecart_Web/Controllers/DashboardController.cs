using Microsoft.AspNetCore.Mvc;
using DocumentFormat.OpenXml.Bibliography;
using Ecart_Services;
using Ecart_Web.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ecart_Web.Models;
using Hangfire.Dashboard;

namespace Ecart_Web.Controllers
{
    public class DashboardController : Controller
    {
        DashboardService service = new DashboardService();
        public IActionResult Index()
        {
            DashboardVM model = new DashboardVM();

            //model.Page = Pages.Dashboard;

            model.UserCount = service.GetUserCount();
            model.CategoryCount = service.GetCategoryCount();
            model.ProductCount = service.GetProductCount();

            return View(model);
        }

        public IActionResult Users(string roleID, string searchTerm, int? pageNo)
        {
            UsersVM model = new UsersVM();
            model.PageNo = pageNo;
            //model.SearchTerm = searchTerm;
            model.RoleID = roleID;


            model.Roles = new List<IdentityRole>();

            return View(model);
        }

        public IActionResult UsersListing(string roleID, string searchTerm, int? pageNo)
        {
            var pageSize = 3;

            UsersListingVM model = new UsersListingVM();

            model.Users = new List<ApplicationUser>();

            //model.Pager = new Pager(10, pageNo, pageSize);

            return View(model);
        }
    }
}
