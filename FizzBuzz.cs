namespace Kattis
{
    internal class FizzBuzz
    {
        List<int> Divisors = new List<int>();

        public void StartFizzBuzzWithUserInput()
        {
            GetNumbersFromUserInput();
            RunFizzBuzz(Divisors[0], Divisors[1], Divisors[2]);
        }


        public List<int> GetNumbersFromUserInput()
        {
            Console.WriteLine("Enter three numbers: ");
            var numberinput = Console.ReadLine();

            var seperatednumbers = numberinput.Split(' ');

            foreach (var number in seperatednumbers)
                Divisors.Add(Convert.ToInt32(number));

            return Divisors;
        }

        public void RunFizzBuzz(int fizzDivisor, int buzzDivisor, int limit)
        {
            for (int i = 1; i < limit + 1; i++)
            {
                if (i % fizzDivisor == 0 && i % buzzDivisor == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % fizzDivisor == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % buzzDivisor == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
        
