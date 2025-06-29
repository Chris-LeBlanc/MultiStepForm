using System.ComponentModel.DataAnnotations;
using MultiStepForm.Types;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class PlanSelectViewModel
    {
        [Required]
        public List<Plan>? Plans { get; set; }

        public Plan SelectedPlan { get; set; }

        public BillingType BillingType { get; set; }
    }
}
