namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double firstOperand, secondOperand, result = 0;
            string operation = "";
            ConsoleKey key;

            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("~~~ Калькулятор ~~~");
                Console.WriteLine("Дробные числа вводить через запятую");

                Console.WriteLine("\nВведите первое число:");
                try
                {
                    firstOperand = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНекорректный ввод. Нажмите на любую клавишу.");
                    key = Console.ReadKey().Key;
                    continue;
                }

                Console.WriteLine("Введите операцию (+ - * /):");
                operation = Console.ReadLine();

                Console.WriteLine("Введите второе число:");
                try
                {
                    secondOperand = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nНекорректный ввод. Нажмите на любую клавишу.");
                    key = Console.ReadKey().Key;
                    continue;
                }

                switch (operation)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        break;
                    case "*":
                        result = firstOperand * secondOperand;
                        break;
                    case "/":
                        if (secondOperand == 0)
                        {
                            Console.WriteLine("\nДелить на ноль нельзя. Результат обнулён.\n");
                            break;
                        }
                        result = firstOperand / secondOperand;
                        break;
                    default:
                        Console.WriteLine("\nНеизвестная операция. Результат обнулён.\n");
                        result = 0;
                        break;
                }

                Console.WriteLine("Результат:\n" + result);

                Console.WriteLine("\nНажмите:\nПерезапуск = любая клавиша\nВыход = 0");
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.D0)
                {
                    Console.WriteLine("\n\nВыход...");
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}