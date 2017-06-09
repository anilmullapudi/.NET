using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
		private IGreeter _greeter;
		private IRestaurantData _restaurantData;

		public HomeController(IRestaurantData restaurantData, IGreeter greeter)
		{
			_restaurantData = restaurantData;
			_greeter = greeter;
		}

		public ContentResult Index()
		{
			return Content("Hello from Home controller");
		}

		public IActionResult Index2()
		{
			return Content("Hello from Home controller");
		}

		public IActionResult Index3()
		{
			var model = new Restaurant { Id=1, Name="JackInTheBox" };
			return new ObjectResult(model);
		}

		public IActionResult Index4()
		{
			var model = new Restaurant { Id = 1, Name = "JackInTheBox" };
			return View(model);
		}

		public IActionResult Index5()
		{
			var model = new HomePageViewModel();
			model.Restaurants = _restaurantData.GetAll();
			model.CurrentMessage = _greeter.GetGreeting();

			return View(model);
		}

		public IActionResult Details(int id)
		{
			var model = _restaurantData.Get(id);

			if(model == null)
			{
				return RedirectToAction(nameof(Index5));
			}

			return View(model);
		}

		public IActionResult Create()
		{
			return View();
		}

	}
}
