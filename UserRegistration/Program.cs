// See https://aka.ms/new-console-template for more information
using UserRegistration;

Console.WriteLine("Hello, World!");
ValidMobileNo patterns = new ValidMobileNo();

if (patterns.RegexPro("91 820880544"))
{
    Console.WriteLine("Valid");
}
else
    Console.WriteLine("Invalid");
Console.ReadKey();