using Microsoft.AspNetCore.Mvc;
using MVCDay01.Models;

namespace MVCDay01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult All()
        {
            ProductBL productBL = new ProductBL();
            List<Product> productList= productBL.GetAll();
            return View("All", productList);
        }


        public IActionResult Details(int id)
        {
            ProductBL productBL = new ProductBL();
            Product productModel = productBL.GetByID(id);  

           
            return View("Details", productModel);
        }

    }
}
