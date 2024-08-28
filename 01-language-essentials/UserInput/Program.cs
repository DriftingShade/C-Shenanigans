string? input;

do
{
    Console.WriteLine("Type something, then hit enter:");
    input = Console.ReadLine();
    if (input != null && input.Trim().Length > 0)
    {
        Console.WriteLine($"You typed: {input}");
    }
} 
while (input == null || input.Trim().Length == 0);
