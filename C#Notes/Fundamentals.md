# Fundamentals For C#

## Creating a new Dotnet Console Application
- `cd` into the directory you want your project to live in.
- `dotnet new console -o ProjectName` to create your new Console App!
- `cd` into your new project folder then run `code .` to open the project by itself in a new window.
- Solution (or `.sln`) file will be automatically generated in your **Solution Explorer**.
- Do all editing in the `Program.cs` file, ignore most everything else.

## General Notes
- Similar to Java, C# is strictly-typed.  You can use the `var` keyword for variables, but this is not best practice in most cases.
- Data Types are similar to Java.  `int`, `string`, `double`, `boolean`, `List<Type>`, etc.

## Notes on Arrays, Lists And Dictionaries

- Arrays have fixed size determined at instantiation
- Lists can dynamically grow/shrink by adding/removing elements
- Lists have more methods (Add, Remove, Contains, etc.) compared to arrays

### Examples

__Arrays__
- `string[] bikes = new string[5];` - Creates array of 5 empty strings
- `string[] bikes = {"Kawasaki"};` - Creates array with one element
- Can loop through arrays using foreach

__Lists__
- `List<string> bikes = new List<string>();` - Creates empty list of strings
- `bikes.Add("BMW");` - Adds element to list
- `bikes.Remove("BMW");` - Removes element from list
- `bikes.Contains("BMW");` - Checks if element exists
- `bikes.Sort();` - Sorts elements in-place
- Can loop through lists using foreach

__Dictionaries__
- `Dictionary<string, string> profile = new Dictionary<string, string>();`
- Store key-value pairs, accessed via `profile["name"]`
- Can loop through dictionaries to get key-value pairs

## Functions
- Example: 
```
static void SayHello()
{ 
    Console.WriteLine("Hello world!");
}
```
- Passing in parameters require the data type to be specified like so:
```
static void SayHelloWithName(string firstName, string lastName)
{
    Console.WriteLine($"Hello {firstName} {lastName}, how are you doing today?");
}
```
- And we invoke the functions like this:
```
SayHello();
// Outputs Hello World!
SayHelloWithName("John", "Doe");
// Outputs Hello John Doe, how are you doing today?
```