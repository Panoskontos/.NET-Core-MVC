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
            // clean view model that we will pass in create dog class
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            // return View("Index");
            return RedirectToAction("Index", "HelloWorld");
        }

        public string Products()
        {
            return "Products Page";
        }




    }
};
