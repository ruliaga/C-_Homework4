Console.Clear();
Console.WriteLine("Введите первое число:");
double number1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double number2=Convert.ToDouble(Console.ReadLine());

int result=Convert.ToInt32(Math.Pow(number1,number2));

Console.WriteLine($"{number1}, {number2} -> {result}");