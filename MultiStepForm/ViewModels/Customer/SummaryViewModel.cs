using MultiStepForm.Types;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class SummaryViewModel
    {
        public BillingType BillingType { get; set; }

        public AddOns AddOns { get; set; }

        public Plan Plan { get; set; }
    }
}
