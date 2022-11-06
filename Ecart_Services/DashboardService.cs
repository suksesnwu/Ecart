using Ecart_Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecart_Services
{
    public class DashboardService
    {
        public int GetUserCount()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            return context.Users.Count();
        }
        public int GetCategoryCount()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            return context.Category.Count();
        }
        public int GetProductsCount()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            return context.Product.Count();
        }
    }
}
