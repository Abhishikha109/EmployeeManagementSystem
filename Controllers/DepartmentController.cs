using Microsoft.AspNetCore.Mvc;

namespace testProject2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public string List()
        {
            return "List() of Department Controller";
        }

        public string Details()
        {
            return "Details() of Department Controller";
        }
    }
}