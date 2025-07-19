using Microsoft.AspNetCore.Mvc;
using MultiStepForm.Types;
using System.ComponentModel.DataAnnotations;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class AddOnViewModel
    {
        public List<int>? AddOn { get; set; }
        
        [BindProperty]
        public List<int>? SelectedAddOn { get; set; }
    }
}
