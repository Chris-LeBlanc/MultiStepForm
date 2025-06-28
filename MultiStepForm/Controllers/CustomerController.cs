using Microsoft.AspNetCore.Mvc;
using MultiStepForm.Web.ViewModels.Customer;

namespace MultiStepForm.Controllers
{
    public class CustomerController : Controller
    {
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

            TempData["Name"] = customer.Name;
            TempData["Email"] = customer.Email;
            TempData["Phone"] = customer.PhoneNumber;


            return RedirectToAction("SignUp_Step2");
        }

        [HttpGet]
        public IActionResult SignUp_Step2()
        {
            return View();
        }

    }
}
