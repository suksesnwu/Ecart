using Ecart_Web.Data;
using Microsoft.AspNetCore.Mvc;
using Ecart_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecart_Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> objList = _db.Product.Include(u => u.Category).Include(u => u.ApplicationType);

            //foreach (var obj in objlist)
            //{
            //    obj.category = _db.category.firstordefault(u => u.id == obj.categoryid);
            //    obj.applicationtype = _db.applicationtype.firstordefault(u => u.id == obj.applicationtypeid);
            //};

            return View(objList);
        }
    }
}
