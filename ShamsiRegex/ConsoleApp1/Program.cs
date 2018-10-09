using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Please write your birth date:");
                var pattern = @"^$|^([1۱][۰-۹ 0-9]{3}[/\/]([0 ۰][۱-۶ 1-6])[/\/]([0 ۰][۱-۹ 1-9]|[۱۲12][۰-۹ 0-9]|[3۳][01۰۱])|[1۱][۰-۹ 0-9]{3}[/\/]([۰0][۷-۹ 7-9]|[1۱][۰۱۲012])[/\/]([۰0][1-9 ۱-۹]|[12۱۲][0-9 ۰-۹]|(30|۳۰)))$";
                Regex re = new Regex(pattern);
                while (true)
                {
                    Console.Write("Date:");
                    var text = Console.ReadLine();
                    if (text == "exit")
                        break;
                    var isMatch = re.IsMatch(text);
                    if (isMatch)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thanks!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Corect!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
