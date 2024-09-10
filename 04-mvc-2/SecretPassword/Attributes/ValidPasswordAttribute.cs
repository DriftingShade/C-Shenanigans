using System.ComponentModel.DataAnnotations;

namespace SecretPassword.Attributes;

public class ValidPasswordAttribute : ValidationAttribute
{
    protected string PasswordContent { get; set; }

    public ValidPasswordAttribute(string passwordContent)
    {
        PasswordContent = passwordContent;
    }
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null || value.ToString() != PasswordContent)
        {
            return new ValidationResult("You got the wrong password!");
        }

        return ValidationResult.Success;

    }
}