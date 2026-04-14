using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("=== Простой калькулятор ===");

        try
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // переход на новую строку

            double result = 0;
            bool valid = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                        throw new DivideByZeroException("Деление на ноль!");
                    result = num1 / num2;
                    break;
                default:
                    valid = false;
                    Console.WriteLine("Некорректная операция!");
                    break;
            }

            if (valid)
                Console.WriteLine($"Результат: {num1} {operation} {num2} = {result:F2}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите числа корректно!");
        }
    }
}