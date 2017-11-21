namespace Exer_11_FiveDifferentNumbers
{
    using System;

    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            bool check = false;

            for (int first = a; first <= b; first++)
            {
                for (int second = a; second <= b; second++)
                {
                    for (int third = a; third <= b; third++)
                    {
                        for (int fourth = a; fourth <= b; fourth++)
                        {
                            for (int fifth = a; fifth <= b; fifth++)
                            {
                                if (first < second && 
                                    second < third && 
                                    third < fourth && 
                                    fourth < fifth)
                                {
                                    Console.Write(first + " ");
                                    Console.Write(second + " ");
                                    Console.Write(third + " ");
                                    Console.Write(fourth + " ");
                                    Console.WriteLine(fifth + " ");
                                    check = true;
                                }
                            }
                        }
                    }
                } 
            }
            if (check == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
