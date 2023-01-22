internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int NumberFisrt = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int NumberSecond = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int NumberThird = int.Parse(Console.ReadLine());

        Console.Write("Введите четвертое число: ");
        int NumberFourth = int.Parse(Console.ReadLine());

        double MegaSum(int NumberFisrt, int NumberSecond)
        {
            double Result = Math.Pow(NumberSecond, 2) + Math.Pow(NumberFisrt, 2);
            return Result;
        }

        double FirstResult = MegaSum(NumberFisrt, NumberSecond);

        double SecondResult = MegaSum(NumberThird, NumberFourth);

        if (FirstResult > SecondResult)
        {
            Console.WriteLine("Первая пара чисел больше по формуле x^2 + y^2");
        }
        else { Console.WriteLine("Вторая пара чисел больше по формуле x^2 + y^2"); }
    }
}