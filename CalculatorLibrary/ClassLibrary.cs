namespace CalculatorLibrary
{
    public class ClassLibrary
    {
        public void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Деление");
                Console.WriteLine("4. Умножение");
                Console.WriteLine("5. Возведение в степень");
                Console.WriteLine("6. Извлечение корня");
                Console.WriteLine("7. Процент от числа");
                Console.WriteLine("8. log");
                Console.WriteLine("9. sin");
                Console.WriteLine("10. ctg");
                Console.WriteLine("0. Выход из программы");
                Console.Write("Выберите операцию: ");
                int digit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                List<double> numbers;
                switch (digit)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        numbers = GetNumbers();
                        Console.WriteLine($"Сумма чисел = {Addition(numbers)}");
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 2:
                        numbers = GetNumbers();
                        Console.WriteLine($"Разность чисел = {Difference(numbers)}");
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 3:
                        numbers = GetNumbers();
                        Console.WriteLine($"Частное чисел = {Division(numbers)}");
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 4:
                        numbers = GetNumbers();
                        Console.WriteLine($"Произведение чисел = {Multiplication(numbers)}");
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 5:
                        Exponentiation();
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 6:
                        Rooting();
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 7:
                        Percentage();
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 8:
                        Log();
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 9:
                        Sin();
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case 10:
                        Ctg();
                        Console.WriteLine("---------------------------------\n");
                        break;
                }
            }
        }
        public List<double> GetNumbers()
        {
            List<double> numbers = new List<double>();
            Console.Write("Введите числа через пробелы: ");
            string input = Console.ReadLine();
            string[] stringNumbers = input.Split(' ');
            foreach (string n in stringNumbers)
            {
                if (double.TryParse(n, out double number) || n == "")
                {
                    if (n != "")
                        numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод, попробуйте снова.\n");
                    break;
                }
            }
            return numbers;
        }

        public double Addition(List<double> numbers)
        {
            double result = 0;
            foreach (double number in numbers)
            {
                result += number;
            }
            return result;
        }

        public double Difference(List<double> numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public double Division(List<double> numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                    result /= numbers[i];
                else
                    throw new DivideByZeroException("Ошибка: деление на ноль!");
            }
            return result;
        }

        public double Multiplication(List<double> numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result *= numbers[i];
            }
            return result;
        }

        public void Exponentiation()
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите степень: ");
            double degree = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(number, degree);
            Console.WriteLine($"{number} в степени {degree} = {result}");
        }

        public void Rooting()
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(number);
            Console.WriteLine($"корень числа {number} = {result}");
        }
        public void Percentage()
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите процент: ");
            double percent = Convert.ToDouble(Console.ReadLine());
            double result = number * percent / 100;
            Console.WriteLine($"{percent}% от {number} = {result}");
        }
        public void Log()
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите основание: ");
            double osn = Convert.ToDouble(Console.ReadLine());
            double result = Math.Log(number, osn);
            Console.WriteLine($"Логарифм по основанию {osn} числа {number} = {result}");
        }
        public void Sin()
        {
            Console.Write("Введите число (градус угла): ");
            double degree = Convert.ToDouble(Console.ReadLine());
            double radians = degree * Math.PI / 180;
            double result = Math.Sin(radians);
            Console.WriteLine($"Синус угла {degree}° = {result}");
        }

        public void Ctg()
        {
            Console.Write("Введите число (градус угла): ");
            double degree = Convert.ToDouble(Console.ReadLine());
            double radians = degree * Math.PI / 180;
            double result = 1 / Math.Tan(radians);
            Console.WriteLine($"Синус угла {degree}° = {result}");
        }
    }
}
