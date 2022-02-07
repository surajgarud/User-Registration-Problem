// See https://aka.ms/new-console-template for more information
using UserRegistration;

Console.WriteLine("Hello, World!");
ValidPassword patterns = new ValidPassword();

if (patterns.RegexPro("surajGarud@95"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();