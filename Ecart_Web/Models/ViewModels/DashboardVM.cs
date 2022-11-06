using Hangfire.Dashboard;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecart_Web.Models.ViewModels
{
    public class DashboardVM //: PageViewModel
    {
        public int UserCount { get; set; }
        public int CategoryCount { get; set; }
        public int ProductCount { get; set; }

    }

    public class UsersVM //: PageViewModel
    {
        public int SearchTerm { get; set; }
        public string RoleID { get; set;}
        public List<IdentityRole> Roles { get; set; }
        public int? PageNo { get; set; }
    }

    public class UsersListingVM //: PageViewModel
    {
        public List<IdentityRole> Roles { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public Pager Pager { get; set; }
    }
}
