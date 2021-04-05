using System;

namespace DefaultProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ulam calculation:");
            Console.WriteLine(UlamSequence.UlamSequence.Ulam(4));
            Console.WriteLine("===================================================");

            //Console.WriteLine("Calculate overtime:");
            //Console.WriteLine(OverTime.OvertTime.CalculateOverTime(new double[] { 9, 18, 40, 2 }));
            //Console.WriteLine("===================================================");

            //Console.WriteLine("Reverste words with to odd length:");
            //Console.WriteLine(ReverseTheOddLengthWords.ReverseTheOddLengthWords.ReverseOdd("Make sure uoy only esrever sdrow of ddo length"));
            //Console.WriteLine("===================================================");
        }
    }
}
