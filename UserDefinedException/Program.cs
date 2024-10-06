// See https://aka.ms/new-console-template for more information
using UserDefinedException;

Temperature temp = new();
try
{
    temp.showTemp();
}
catch (TempIsZeroException e)
{
    Console.WriteLine("TempIsZeroException: {0}", e.Message);
}
Console.ReadKey();
