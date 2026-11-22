using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Validations
{

public class DueDateAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is not DateOnly date)
            return false;

        var today = DateOnly.FromDateTime(DateTime.Today);
        var oneYearLater = today.AddYears(1);

        return date >= today && date <= oneYearLater;
    }
}
}