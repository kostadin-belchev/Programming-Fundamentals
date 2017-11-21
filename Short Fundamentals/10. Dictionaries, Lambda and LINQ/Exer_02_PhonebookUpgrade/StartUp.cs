namespace Exer_02_PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {

                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    phonebook[name] = number;
                }
                else if (input[0] == "S")
                {
                    string name = input[1];

                    if (phonebook.ContainsKey(name))
                    {
                        foreach (var person in phonebook)
                        {
                            if (person.Key == name)
                            {
                                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var person in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", person.Key, person.Value);
                    }
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
