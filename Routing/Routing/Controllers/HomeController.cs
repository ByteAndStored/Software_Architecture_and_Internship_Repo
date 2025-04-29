using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers;

public class HomeController : Controller
/*genelde IActionResult dönülür çünkü actionın birden fazla
ve türde cevap dönebilmesini sağlarmış */
{
    public IActionResult Index()
    {
        return View ();
    }

    public IActionResult Details()
    {
        return View ();
    }

    [HttpGet] //metod sadece httpGet isteklerini kabul edecek demektir
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost] //formdan gelen veriyi alan action
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            //eğer formdan gelen veri valid ise işlem yapılır
            return RedirectToAction ("Index");
        }
        //hatalıysa formu tekrar göster
        return View();
    }




}