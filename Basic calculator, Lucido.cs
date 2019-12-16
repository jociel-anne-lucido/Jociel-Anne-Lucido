
using System;

public static class SimpleCalculator
{

    static int Main()
    {

        double NUMBER1;
        double NUMBER2;
        char operation;
        char redo;
        do
        {
            Console.Write(" Enter the operation (A, D, S, M) : ");
            operation = char.Parse(Console.ReadLine());
            Console.Write(" Enter two numbers(");
            Console.Write(operation);
            Console.Write("):");
            Console.Write("\n");
            Console.Write(" fist number: ");
            NUMBER1 = double.Parse(Console.ReadLine());
            Console.Write(" second number: ");
            NUMBER2 = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case 'M':
                    Console.Write(" The product of two numbers is equal to (");
                    Console.Write(NUMBER1);
                    Console.Write(",");
                    Console.Write(NUMBER2);
                    Console.Write("): ");
                    Console.Write(NUMBER1 * NUMBER2);
                    Console.Write("\n");
                    break;
                case 'A':
                    Console.Write(" The sum of two numbers is equal to (");
                    Console.Write(NUMBER1);
                    Console.Write(",");
                    Console.Write(NUMBER2);
                    Console.Write("): ");
                    Console.Write(NUMBER1 + NUMBER2);
                    Console.Write("\n");
                    break;
                case 'S':
                    Console.Write(" The difference of two numbers is equal to (");
                    Console.Write(NUMBER1);
                    Console.Write(",");
                    Console.Write(NUMBER2);
                    Console.Write("): ");
                    Console.Write(NUMBER1 - NUMBER2);
                    Console.Write("\n");
                    break;
                case 'D':
                    Console.Write(" The quotient of two numbers is equal to (");
                    Console.Write(NUMBER1);
                    Console.Write(",");
                    Console.Write(NUMBER2);
                    Console.Write("): ");
                    if (NUMBER2 == 0)
                    {
                        Console.Write("not valid");
                        Console.Write("\n");
                    }
                    Console.Write((NUMBER1 / NUMBER2));
                    Console.Write("\n");
                    break;
                default:
                    Console.Write(" INVALID OPERATION ");
                    Console.Read();
                    break;
            }
            Console.Write(" Press J to continue: \n");
            redo = char.Parse(Console.ReadLine());
        } while (redo == 'J');


        // uncomment above line if your are on windows

        return 0;
    }
}

