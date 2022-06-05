using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;
namespace mymvcapp.Controllers;

public class HelloWorldController : Controller
{

    //    Creating New Links
    public IActionResult Index()
    {
        // Models used
        DogViewModel dogo = new DogViewModel() { Name="Bobby Lasi", Age=23 };
        // View used
        return View(dogo);
    }

    public string Hello()
    {
        return "Who is there";
    }

    public string Products()
    {
        return "Products Page";
    }




}
