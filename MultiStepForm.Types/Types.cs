using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace MultiStepForm.Types
{
    public class Parm
    {
        public string? Name { get; set; }
        public SqlDbType DataType { get; set; }
        public object? Value { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; }

        public Parm(string? name, SqlDbType dataType, object? value, int size = 0, ParameterDirection direction = ParameterDirection.Input)
        {
            Name = name;
            DataType = dataType;
            Value = value;
            Size = size;
            Direction = direction;
        }
    }

    public enum ErrorType
    {
        Model,
        Business
    }

    public enum BillingType
    {
        Monthly,
        Yearly
    }

    public enum Plan
    {
        Arcade = 9,
        Advanced = 12,
        Pro = 15
    }

    public enum AddOns
    {
        [Display(Name = "Online Services")]
        OnlineService,
        [Display(Name = "Large Storage")]
        LargerStorage,
        [Display(Name = "Customizable Profile")]
        CustomizableProfile
    }
}
