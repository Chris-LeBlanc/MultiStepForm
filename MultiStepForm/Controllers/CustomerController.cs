using Microsoft.AspNetCore.Mvc;
using MultiStepForm.Types;
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

            HttpContext.Session.SetString("Name", customer.Name!);
            HttpContext.Session.SetString("Email", customer.Email!);
            HttpContext.Session.SetString("Phone", customer.PhoneNumber!);

            return RedirectToAction("SignUp_Step2");
        }

        [HttpGet]
        public IActionResult SignUp_Step2()
        {
            var vm = new PlanSelectViewModel
            {
                Plans = Enum.GetValues(typeof(Plan)).Cast<Plan>().ToList(),
            };

            return View("SignUp_Step2", vm);
        }

        [HttpPost]
        public IActionResult SignUp_Step2(PlanSelectViewModel plan)
        {
            if (!ModelState.IsValid)
            {
                var vm = new PlanSelectViewModel
                {
                    Plans = Enum.GetValues(typeof(Plan)).Cast<Plan>().ToList(),
                };

                return View("SignUp_Step2", vm);
            }


            HttpContext.Session.SetString("Plan", plan.SelectedPlan.ToString());
            HttpContext.Session.SetString("BillingType", plan.BillingType.ToString());

            return View("SignUp_Step3");
        }

        [HttpGet]
        public IActionResult SignUp_Step3()
        {
            var vm = new AddOnViewModel
            {
                AddOn = Enum.GetValues(typeof(AddOns)).Cast<AddOns>().ToList()
            };

            return View("SignUp_Step3", vm);
        }

    }
}
