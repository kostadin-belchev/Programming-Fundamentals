namespace Exer_01_Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                string name = input[1];

                if (input[0] == "A")
                {
                    phonebook[name] = input[2];
                }
                else if (input[0] == "S")
                {
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

                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
