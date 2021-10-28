using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testProject2.Models;
using testProject2.ViewModels;

namespace testProject2.Controllers
{
    //[Route("[controller]/[action]")] // it expects both controller and action simultaneously
    //[Route("Home")] to avoid repeatition in every action
    
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // [Route("")]
        // [Route("~/Home")] // this route is called when we only HOME in URL.
        //[Route("[action]")]
        //[Route("Home/Index")]
        public ViewResult Index()
        {
            return View(_employeeRepository.GetAllEmployee());
            //return _employeeRepository.GetEmployee(1).Name;
        }

        //[Route("{id?}")]
        //[Route("[action]/{id?}")]
        //[Route("Home/Details/{id?}")]
        public ViewResult Details(int? id)
        {
            //Employee employee = _employeeRepository.GetEmployee(id);
            
            // return View();
            
            // ways to use .cshtml class
            //return View(model);
            //return View("_Layout.cshtml");
            //return View("Index");

            // ViewData (data passing method)
            // ViewData["Employee"] = model;
            // ViewData["PageTitle"] = "Employee Details";
            
            // ViewBag (data passing method)
            // ViewBag.Employee = model;
            // ViewBag.PageTitle = "Employee Details";
            
            // ViewStronglyTyped
            // ViewBag.PageTitle = "Employee Details";
            // return View(model);

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("Details",new {id = newEmployee.Id});   
            }
            return View();
        }
        // private readonly ILogger<HomeController> _logger;
        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
