using Microsoft.AspNetCore.Mvc;
using SimpleDatabaseConnectingProject.Entities;
using SimpleDatabaseConnectingProject.Models;
using SimpleDatabaseConnectingProject.SimpledbContext;
using System.Diagnostics;

namespace SimpleDatabaseConnectingProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly SimpleDbContext _context;

		public HomeController(ILogger<HomeController> logger, SimpleDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(User user)
		{
			_context.Add(user);
			_context.SaveChanges();
			return RedirectToAction("Users");
		}

		public IActionResult Users()
		{
			List<User>? users = _context.Users.ToList();
			return View(users);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}