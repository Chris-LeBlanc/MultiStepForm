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
        Arcade,
        Advanced,
        Pro
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

    // public static class SessionExtensions
    // {
    //     public static void SetObject<T>(ISession session, string key, T value)
    //     {
    //         session.SetString(key, JsonSerializer.Serialize(value));
    //     }

    //     public static T GetObject<T>(ISession session, string key)
    //     {
    //         var value = session.GetString(key);
    //         return value == null ? default : JsonSerializer.Deserialize<T>(value);
    //     }
    // }
}
