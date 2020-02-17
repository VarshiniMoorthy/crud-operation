using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsDetails.respository;
using Product.Entity;

namespace OnlineShopping.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        ProductsRespository productsRespository;
        public IndexController()
        {
            productsRespository = new ProductsRespository();

        }
        public ActionResult Index()
        {
            IEnumerable<ProductData> productData = productsRespository.GetProductDetails();
            return View(productData);
        }
        public ActionResult AddProdcut()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProdcut(ProductData product)
        {
            productsRespository.AddProductDetails(product);
            TempData["Message"] = "product added succesfully";
            return RedirectToAction("Index");
          
        }
        public ActionResult Delete(int id)
        {
            productsRespository.DeleteProduct(id);
            TempData["Message"] = "product deleted succesfully";
            return RedirectToAction("Index");
            
        }
    }
}