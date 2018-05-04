using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Возможные операции:\n"+
                "+ - сложить A и В\n" +
                "- - вычесть В из А\n" +
                "* - умножить А на В\n" +
                "/ - разделить А на В");
            String exit = "";
            while (exit!="exit")
            {
                Console.WriteLine("Введите первое число:");
                String A = Console.ReadLine();
                Console.WriteLine("Введите второе число:");
                String B = Console.ReadLine();
                Console.WriteLine("Введите операцию:");
                String Operation = Console.ReadLine();
                try
                    {
                        Calculate(A, B, Operation);
                    }
                catch (Exception)
                    {
                        Console.WriteLine("ошибка выполнения операции!");
                    }
                Console.WriteLine("наберите exit, если хотите выйти");
                exit = Console.ReadLine();
            }
        }

        private static void Calculate(string A, string B, string Operation)
        {
            float a = float.Parse(A);
            float b = float.Parse(B);
            float result = 0;
            switch (Operation)
            {
                case "+":
                    {
                        result = a + b;
                        break;
                    }
                case "-":
                    {
                        result = a - b;
                        break;
                    }
                case "*":
                    {
                        result = a * b;
                        break;

                    }
                case "/":
                    {
                        result = a / b;
                        break;
                    }
                default: Console.WriteLine("Недопустимая операция"); break;
            }
            Console.WriteLine("Ответ: " + result);
        }
    }
}