using System;

public class Quad_Equation
{
    public static void Main()
    {
        if (Console.BackgroundColor == ConsoleColor.Black)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();

            double a, b, c;

            double D, x1, x2;
            Console.Write("\n\n");
            Console.Write("Изчислете корените на Квадратното уравнение: ax^2 + bx + c = 0\n");
            Console.Write("--------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Въведете стойността на a : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Въведете стойността на b : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Въведете стойността на c : ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");

            D = b * b - 4 * a * c;
            if (D == 0) //Ако дискриминантата е 0:
            {
                Console.WriteLine($"\x1b[32mD = {D:F2} -> Уравнението има един двоен корен.\x1b");
                Console.WriteLine();
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.WriteLine($"Първи корен x1 = {x1:F2}");
                Console.WriteLine($"Втори корен x2 = {x2:F2}");
                Console.ReadLine();
            }
            else if (D > 0) //Ако дискриминантата е по-голяма от 0:
            {
                Console.WriteLine($"\x1b[32mD = {D:F2} -> Уравнението има два реални корена.\x1b");
                Console.WriteLine();

                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"Първи корен x1 = {x1:F2}");
                Console.WriteLine($"Втори корен х2 = {x2:F2}");
                Console.ReadLine();
            }
            else //Ако дискриминантата е по-малка от 0:
            {
                Console.WriteLine("\x1b[31mУравнението няма реални корени! => Няма решение!\x1b");
                Console.ReadLine();
            }
        }
    }
}