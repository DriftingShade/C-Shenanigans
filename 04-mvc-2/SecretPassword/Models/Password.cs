#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using SecretPassword.Attributes;

namespace SecretPassword.Models;

public class Password
{
    [ValidPassword("samcooke")]
    public string Content { get; set; }
}

