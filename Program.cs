namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Part 1 - Prompter");
            Console.WriteLine("Enter a minimum value:");
            int userMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a maximum:");
            int userMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Now enter a number between {userMin} and {userMax}:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            while(userNumber < userMin || userNumber > userMax)
            {
                Console.WriteLine($"Enter a number BETWEEN {userMin} and {userMax}:");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Part 2 - Percent Passing");
            Console.WriteLine("How many scores to enter?");
            int amountScores = Convert.ToInt32(Console.ReadLine());
            int percent;
            int passes = 0;
            int scoresLeft = amountScores;
            while (scoresLeft > 0)
            {
                Console.WriteLine("Enter your percentage:");
                percent = Convert.ToInt32(Console.ReadLine());
                scoresLeft --;
                if (percent > 70)
                {
                    passes ++;
                }
            }
            double final = ((double)passes/amountScores*100);
            Console.WriteLine($"{(int)final}% of the scores were above 70.");
            Console.WriteLine();
            Console.WriteLine("Part 3 - Oddsum");
            Console.WriteLine("Ether a number (preferably an odd one):");
            int oddNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Part 4 - Random Numbers");
            Console.WriteLine("Enter a minimum:");
            userMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a maximum:");
            userMax = Convert.ToInt32(Console.ReadLine());
            userMax++;
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(random.Next(userMin,userMax));
            }
        }
    }
}