using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiStepForm.Models;

namespace MultiStepForm.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
