using MultiStepForm.Types;

namespace TLGManager.Model
{
    public class ValidationError
    {
        public ValidationError(string desc, ErrorType errType, string propertyName = null)
        {
            Description = desc;
            ErrorType = errType;
            PropertyName = propertyName;
        }

        public string Description { get; set; }
        public ErrorType ErrorType { get; set; }
        public string? PropertyName { get; set; }
    }
}