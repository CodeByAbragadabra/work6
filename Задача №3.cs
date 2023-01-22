internal class Program
{
    private static void Main(string[] args)
    {
        // Рандомайзер заполняет массив числами от 0 до 100
        int[] Numbers = new int[25];
        Random rand = new Random();

        for (int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = rand.Next(0, 100);
        }

        // Вывод массива
        Console.Write("Изначальный массив: ");
        foreach (int i in Numbers)
        {
            Console.Write(i + " ");
        }

        // Функция поиска
        int SearchInArray(ref int[] Array, int Index)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Index) { return i; }
            }
            return -1;
        }

        // Берем от пользователя число и пихаем в фунуцию. Затем выводим ответ
        Console.Write("\nВведите число, которое хотите найти: ");
        int NumberOfElement = int.Parse(Console.ReadLine());

        int Result = SearchInArray(ref Numbers, NumberOfElement);

        Console.WriteLine($"Ваше число находится в элементе {Result}. Если результат -1, то число не было найдено");
    }
}