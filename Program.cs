// See https://aka.ms/new-console-template for more information


// Main Method
using DotNetSamples;

public class Program
{
    static public void Main(String[] args)
    {
        PropertyTest p = new PropertyTest()
        {
            MyFirstProperty = 4
        };
        Console.WriteLine("prop " + p.MyFirstProperty);
    }

}