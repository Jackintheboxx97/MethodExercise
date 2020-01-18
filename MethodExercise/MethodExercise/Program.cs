using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite name?");
            var myName = Console.ReadLine();

            AddIt(6, 7);
            AddIt(12, 8);

            MultiThem(3, 6);
            MultiThem(4, 3);
            MultiThem(3, 4, 6);

            var response = Console.ReadLine();
            Console.WriteLine(CheckFacts(response));
        }

        public static void AddIt(int numAny, int anyNum)
        {
            Console.WriteLine(numAny + anyNum);


        }

        public static int MultiThem(int variNum, int numVari)
        {
            return variNum * numVari;

        }
        public static int MultiThem(int variNum, int numVari, int numThird)
        {
            return variNum * numVari * numThird;

        }
        public static bool CheckFacts(string sentence)
        {
            if (sentence == "Jack is a girl.")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum + firstNum + secondNum;

        }

        public static decimal Add(decimal firstNum, decimal secondNum)
        {
            return firstNum + secondNum;

        }

      






}