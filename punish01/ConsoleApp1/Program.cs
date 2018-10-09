using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string List = "1- students" + "\n" + "2- punishments" + "\n" + "3- go ahead";
                Console.WriteLine(List);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Choose an Item:");
                var choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine("students");
                    string[] students = new string[]
               {
                    "Galiya rezadoust"

              };

                    while (students[i]!="finish")
                    {
                        Console.Clear();
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        Console.WriteLine("-----------------");
                        Console.WriteLine("New Name:");
                        
                        var input = Console.ReadLine();
                        AddToArray(ref students, input);

                        

                    }
                }


                else if (choose == "2")
                {
                    Console.WriteLine("punishments");
                    string[] punishments = new string[]
             {
                    "extera practise"

            };

                    while (punishments[i]!= "finish")
                    {
                        Console.Clear();
                        for (int i = 0; i < punishments.Length; i++)
                        {
                            Console.WriteLine(punishments[i]);
                        }
                        Console.WriteLine("-----------------");
                        Console.WriteLine("New punishments:");
                        var input = Console.ReadLine();
                        AddToArray(ref punishments, input);

                    }
                }
                else if (choose == "3")
                {
                    
                    Console.WriteLine("go ahead");
                    while (true)
                    {
                        //Console.WriteLine(Random studedent[i] == Random punishments[i]);
                    }


                }
            }



            Console.ReadKey();
        }

        static void AddToArray(ref string[] names, string newName)
        {
            var newArray = new string[names.Length + 1];
            for (int i = 0; i < names.Length; i++)
            {
                newArray[i] = names[i];
            }
            newArray[newArray.Length - 1] = newName;
            names = newArray;
        }


    }

}  
