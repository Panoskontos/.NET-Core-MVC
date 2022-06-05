using Microsoft.AspNetCore.Mvc;
using mymvcapp.Models;


namespace mymvcapp.Controllers
{

    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();
        //    Creating New Links
        public IActionResult Index()
        {
            // View used
            return View(dogs);
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
            dogs.Add(dogViewModel);
            return RedirectToAction("Index", "HelloWorld", new { dogViewModel });
        }

        public string Products()
        {
            return "Products Page";
        }




    }
};
