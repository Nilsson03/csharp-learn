using System;

try {
    Console.Write("Пожалуйста, введите первое число от 0 до 255:");
    int firstNumber = int.Parse(Console.ReadLine()!); 
    Console.Write("Пожалуйста, введите второе число от 0 до 255:");
    int secondNumber = int.Parse(Console.ReadLine()!);

    if (firstNumber < 0 || firstNumber > 255 || secondNumber < 0 || secondNumber > 255)
    {
        throw new OverflowException("Числа должно быть в диапазоне от 0 до 255");
    }

    int divided = firstNumber / secondNumber;
    Console.WriteLine($"Результат деления {firstNumber} на {secondNumber} равно {divided}");
} catch (FormatException)
{
    Console.WriteLine("Вы ввели неверное значение, это точно число?");
} catch (DivideByZeroException)
{
    Console.WriteLine("Нельзя делить на ноль, не учили в школе?");
} catch (OverflowException)
{
    Console.WriteLine("Число слишком маленькое или большое, введите число от 0 до 255!");
}
