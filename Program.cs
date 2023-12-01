using System;

class Program {
    double[] numbers = {0, 0, 0};
    string? operation;

    static void Main() {

        Program calculator = new();

        try
        {
            Console.WriteLine("First");
            calculator.numbers[0] = Double.Parse(Console.ReadLine()!);
            Console.WriteLine("Second");
            calculator.numbers[1] = Double.Parse(Console.ReadLine()!);
        }
        catch (System.Exception)
        {
            Console.Clear();
            Console.WriteLine("Invalid input!");
            Main();
            return;
        }

        Console.WriteLine("Operation");
        calculator.operation = Console.ReadLine()!.ToLower();

        switch(calculator.operation) {
            case "+":
                calculator.numbers[2] = calculator.numbers[0] + calculator.numbers[1];
                break;

            case "-":
                calculator.numbers[2] = calculator.numbers[0] - calculator.numbers[1];
                break;

            case "x":
                calculator.numbers[2] = calculator.numbers[0] * calculator.numbers[1];
                break;

            case "/":
                if (calculator.numbers[0] == 0 & calculator.numbers[1] == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Error: can't divide by 0");
                    Main();
                }
                else
                {
                    calculator.numbers[2] = calculator.numbers[0]/calculator.numbers[1];
                }
                break;
            
            default:
                Console.Clear();
                Console.WriteLine("Invalid!");
                Main();
                break;
        }

        Console.Clear();
        Console.WriteLine("The Result Is: " + calculator.numbers[2]);
        Console.WriteLine("Press ANY key to exit!");
        Console.ReadKey();
        Dialog();
    }

    private static void Dialog() {

        Console.Clear();
        Console.WriteLine("Exit?");
        Console.WriteLine("Yes - No");
        string reply = Console.ReadLine()!.ToLower();

        switch (reply)
        {
            case "y" or "yes":
                Environment.Exit(1);
                break;

            case "n" or "no":
                Console.Clear();
                Main();
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid!");
                Dialog();
                break;
        }
    }
}