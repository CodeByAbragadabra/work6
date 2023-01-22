internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int First = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int Second = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int Third = int.Parse(Console.ReadLine());

        int MinimalNumber(int a, int b)
        {
            int Minimal = Math.Min(a, b);
            return Minimal;
        }

        int FisrtMinimal = MinimalNumber(First, Second);
        if (FisrtMinimal < Third)
        {
            Console.WriteLine($"Минимальное: {FisrtMinimal}");
        }
        else { Console.WriteLine($"Минимальное: {Third}"); }
    }
}