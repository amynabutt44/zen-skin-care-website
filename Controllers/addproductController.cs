using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	public class addproductController : Controller
	{
		public IActionResult Index()
		{

			productRepository productRepository = new productRepository();
			 List<products>   p      =  productRepository.viewproducts();
			return View(p);

        }
		[HttpGet]
		public ViewResult add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult add(string product_name, string product_price , string product_description)
		{

		    products p = new products();
			p.name = product_name;
			p.price= product_price;
			p.description = product_description;
			

			productRepository pr = new productRepository();
			pr.add(p);

            return RedirectToAction("Index", "addproduct");
        }
		[HttpGet]
		public ViewResult update()
		{
			return View();
		}

		[HttpPost]
		public IActionResult update(string product_name,string product_description)
		{
			products p = new products();
			p.name = product_name;
			p.description = product_description;
			productRepository pr = new productRepository();
			pr.update(p);
            return RedirectToAction("Index", "addproduct");
        }
	}

}	
