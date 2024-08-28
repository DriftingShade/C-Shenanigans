static void SayHello()
{
    Console.WriteLine("Hello! How are you doing today?");
}
SayHello();

static void SayHelloWithName(string firstName, string lastName)
{
    Console.WriteLine($"Hello, {firstName} {lastName}! How are you doing today?");
}
SayHelloWithName("John", "Doe");

static double GiveMeAnInt(double number)
{
    return number;
}
var pi = 3;

Console.WriteLine(GiveMeAnInt(pi));