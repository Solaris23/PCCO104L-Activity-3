using System;

class Program
{
    public static void Main(string[] args)
    {
        int inputValue;
        do
        {
            Console.Write("Enter a non-negative number (0 to exit): ");
            if (!int.TryParse(Console.ReadLine(), out inputValue))
            {
                Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
                continue;
            }

            if (inputValue == 0)
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            if (inputValue < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
                continue;
            }

            for (int i = 1; i <= inputValue; i++)
            {
                for (int j = 1; j <= inputValue - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        } while (true);
    }
}






/*

public class Main {
    public static void main(String[] args) {
        for (int i = 1; i <= 5; i++) {

            for (int k = 5; k > i; k--) {
                System.out.print(" ");
            }

            for (int j = 1; j <= i; j++) {
                System.out.print(i + " ");
            }
            System.out.println(); 
        }
    }
}

*/