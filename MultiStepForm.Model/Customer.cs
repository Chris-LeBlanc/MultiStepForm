using System.Numerics;
using MultiStepForm.Types;

namespace MultiStepForm.Model
{
    public class Customer
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public Plan Plan { get; set; }

        public AddOns AddOn { get; set; }

        public BillingType BillingType { get; set; }
    }
}
