using System;

namespace DeleteMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to add together?");
            int userAmount = int.Parse(Console.ReadLine());


            int[] numbers = new int[userAmount];

            for (int i = 0; i < userAmount; i++)
            {                
                Console.WriteLine("Please enter a number");
                int userNumber = int.Parse(Console.ReadLine());

                numbers[i] = userNumber;
            }

            int sumAll = Sum(numbers);

            Console.WriteLine(sumAll);
            Console.ReadLine();

            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            
            //Console.WriteLine("What is your age?");
            //string userAge = Console.ReadLine();

            //var message = MyMessage(userName, userAge);
            //Console.WriteLine(message);
        }

        public static void MyMethod(string text)
        {
            Console.WriteLine(text);
        }

        public static string MyMessage(string name, string age)
        {
            var sentence = $"Hello {name}, how does it feel to be {age}?";

            MyMethod(sentence);

            return sentence;
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;

            foreach(int num in args)
            {
                sum += num;
            }

            return sum;
        }
    }
}
