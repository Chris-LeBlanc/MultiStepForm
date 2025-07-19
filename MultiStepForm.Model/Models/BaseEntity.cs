using TLGManager.Model;

namespace MultiStepForm.Model
{
    public abstract class BaseEntity
    {
        public List<ValidationError> Errors { get; set; } = new();

        public void AddError(ValidationError error)
        {
            Errors.Add(error);
        }
    }
}