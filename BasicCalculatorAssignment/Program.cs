namespace BasicCalculatorAssignment
{
    class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int choice = Convert.ToInt32(Console.ReadLine());
                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (choice == 5) break;
                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double first = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double second = Convert.ToDouble(Console.ReadLine());
                // Task 5. Create double variable for default result value and assign it to be 0
                double defaultValue = 0;
                // Task 6. Handle choices using switch statement
                switch (choice)
                {
                    case 1:
                        defaultValue = Addition(first, second);

                        break;
                    case 2:
                        defaultValue = Subtraction(first, second);

                        break;
                    case 3:
                        defaultValue = Multiplication(first, second);

                        break;
                    case 4:
                        if (second != 0)
                        {
                            defaultValue = Division(first, second);

                        }
                        else defaultValue = -1;
                        break;

                }
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                // Task 7. Print out the result
                if (defaultValue != -1) Console.WriteLine(defaultValue);
                else Console.WriteLine("infinite");
            }
        }

        // Declare your methods/functions here
        static double Addition(double a, double b)
        {
            return a + b;
        }
        static double Subtraction(double a, double b)
        {
            return a - b;
        }
        static double Multiplication(double a, double b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
