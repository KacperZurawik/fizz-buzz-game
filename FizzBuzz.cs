using System;

namespace Homework5
{
    public class FizzBuzz
    {
        public void Play()
        {
            bool isGameRunning = true;

            while (isGameRunning)
            {
                Console.Write("Podaj jakąś liczbę (0 kończy grę): \t");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine("Koniec gry!");
                    isGameRunning = false;
                    continue;
                }

                int DivisibleByThree = number % 3;
                int DivisibleByFive = number % 5;

                if (DivisibleByThree == 0 && DivisibleByFive == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                }
                else if (DivisibleByThree == 0)
                {
                    Console.WriteLine("Fizz!");
                }
                else if (DivisibleByFive == 0)
                {
                    Console.WriteLine("Buzz!");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
