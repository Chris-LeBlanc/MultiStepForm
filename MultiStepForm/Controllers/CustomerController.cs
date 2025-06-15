using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiStepForm.Models;
using MultiStepForm.Web.ViewModels.Customer;

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
        public IActionResult SignUp_Step1()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp_Step1(PersonalInfoViewModel customer) 
        { 
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View();
        }

    }
}
