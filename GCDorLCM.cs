using System;
class GCDorLCM
{
    static int GreatestCommonDiviser(int a, int b)
    {
        int Remainder;

        while (b != 0)
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }

        return a;
    }
    static void Main()
    {
        int a, b, n;
        Console.WriteLine("This program calculates Greatest Common Diviser and Least Common Multiple.");
        Console.WriteLine("Enter your first number :");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter your second number: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Now type what you want GCD or LCM.");
        string gcdOrLcm = Console.ReadLine();
        switch (gcdOrLcm)
        {
            case "gcd":
                Console.WriteLine("Greatest common diviser of {0} and {1} is {2}.", a, b, GreatestCommonDiviser(a, b));
                break;
            case "lcm":
                Console.WriteLine("You can find n-th by size lcm. Do you want to?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "yes":
                        Console.WriteLine("What is the n-th by size lcm you want to find?");
                        n = int.Parse(Console.ReadLine());
                        int lcm = a * b / GreatestCommonDiviser(a, b);
                        Console.WriteLine("Your {0}th by size lcm of {1} and {2} is {3}.", n, a, b, n * lcm);
                        break;
                    case "no":
                        lcm = a * b / GreatestCommonDiviser(a, b);
                        Console.WriteLine("Least common multiple of {0} and {1} is {2}.", a, b, lcm);
                        break;
                    default:
                        Console.WriteLine("This is not a valid answer.");
                        break;
                }
                break;
            default:
                Console.WriteLine("This is not valid.");
                break;
        }
    }
}

