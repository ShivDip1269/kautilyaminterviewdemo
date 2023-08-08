using kautilyaminterviewdemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace kautilyaminterviewdemo.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _context;

       public  ProductController(AppDbContext context)
            {
            _context=context;

        }
        public IActionResult Index()
        {
            var product = _context.Product.ToList();


            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (model != null)
            {
                _context.Product.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
           
            return View();
        }

    }
}
