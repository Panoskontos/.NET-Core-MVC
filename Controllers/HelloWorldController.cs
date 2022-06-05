using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;


namespace mymvcapp.Controllers
{

    public class HelloWorldController : Controller
    {

        //    Creating New Links
        public IActionResult Index()
        {
            // Models used
            DogViewModel dogo = new DogViewModel() { Name = "Bobby Lasi", Age = 23 };
            // View used
            return View(dogo);
        }

        public IActionResult Create()
        {
            return View();
        }

        public string Products()
        {
            return "Products Page";
        }




    }
};
