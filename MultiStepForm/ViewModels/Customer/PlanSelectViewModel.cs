using System.ComponentModel.DataAnnotations;
using MultiStepForm.Types;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class PlanSelectViewModel
    {
        
        public List<int>? Plans { get; set; }

        [Required]
        public int SelectedPlan { get; set; }

        public bool BillingType { get; set; } = false;
    }
}
