using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My dictionary");
            var mydic = new Dictionary<string, string>();

            mydic.AddDictionary("Contr1", "Kazahstan");
            mydic.AddDictionary("Contr2", "Armenia");
            mydic.AddDictionary("Contr3", "Uzbec");
            mydic.AddDictionary("Contr4", "China");

            Console.WriteLine(mydic.ToString());
            Console.WriteLine("Dictionary have {0} records", mydic.Length);
            Console.WriteLine(new string('-', 30));       //30 символов "-"
            Console.WriteLine("1 -replacement record, 2 - display record");
            Console.WriteLine("Enter your choice");
            string mychoice = Console.ReadLine();
            switch (mychoice)
            {
                case "1" :
                    Console.WriteLine("Enter nuber record for replace");
                    string mystr0 = Console.ReadLine();
                    if (string.IsNullOrEmpty(mystr0))
                        Console.WriteLine("You did not enter the number in the dictionary");
                    else
                    {
                        int number = Convert.ToInt32(mystr0);
                        Console.WriteLine(mydic[number - 1]);
                        Console.WriteLine("Enter the new country value");
                        string newcountry = Console.ReadLine();
                        if (string.IsNullOrEmpty(mystr0))
                        { 
                            Console.WriteLine("You do not enter a value");
                            return;
                        }
                        else
                        {
                            mydic.ReplaceValue(number - 1, newcountry);
                            Console.WriteLine(mydic.ToString());
                        }
                    }
                    break;

                case "2" :
                    Console.WriteLine("Enter the number of the entry in the dictionary:");
                    string mystr = Console.ReadLine();
                    if (string.IsNullOrEmpty(mystr))
                        Console.WriteLine("You did not enter the number in the dictionary");
                    else
                    {
                        int number = Convert.ToInt32(mystr);
                        Console.WriteLine(mydic[number - 1]);
                        return;
                    }
                    Console.WriteLine("Enter a value to search");
                    string valp = Console.ReadLine();
                    Console.WriteLine(mydic[valp]);
                    break;
            }
            // Delay.
            Console.ReadKey();
        }
    }
}
