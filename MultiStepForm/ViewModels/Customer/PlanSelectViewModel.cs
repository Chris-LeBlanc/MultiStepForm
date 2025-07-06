using System.ComponentModel.DataAnnotations;
using MultiStepForm.Types;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class PlanSelectViewModel
    {
        
        public List<Plan>? Plans { get; set; }

        [Required]
        public Plan SelectedPlan { get; set; }

        public bool BillingType { get; set; } = false;
    }
}
