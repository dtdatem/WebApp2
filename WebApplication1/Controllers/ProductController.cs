using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDBContext _context;

        public ProductController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            
            try
            {
                var product = _context.Products.Find(id);
                return View(product);
            }
            catch
            {
            }
            return View();
        }
        public IActionResult ListProduct(int Id) {
           var prolist = this._context.Products.Where(p=>p.CategoryId==Id).ToList();
            return View(prolist);
        }
    }
}
