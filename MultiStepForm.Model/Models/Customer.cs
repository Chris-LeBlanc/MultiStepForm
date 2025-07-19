using System.Numerics;
using MultiStepForm.Types;

namespace MultiStepForm.Model
{
    public class Customer : BaseEntity
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public int Plan { get; set; }

        public int AddOn { get; set; }

        public int BillingType { get; set; }
    }
}
