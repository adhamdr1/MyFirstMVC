using Microsoft.AspNetCore.Mvc;
using Product_Assiment.Models;

namespace Product_Assiment.Controllers
{
    public class ProductController : Controller
    {
        //  /Product/ShowAll
        public IActionResult ShowAll()
        {
            ProductBL productBL = new ProductBL();
            List<Product> productsListModel = productBL.GetAll();
            return View("ShowAll", productsListModel);
        }

        //  /Product/ShowProduct?id=1
        public IActionResult ShowProduct(int id)
        {
            ProductBL productBL = new ProductBL();
            Product productModel = productBL.GetProductById(id);
            if (productModel == null)
            {
                return NotFound();
            }
            return View("ShowProduct", productModel);
        }
    }
}
