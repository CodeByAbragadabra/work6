// Рандомайзер
int[] Numbers = new int[30];
Random rand = new Random();

for (int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = rand.Next(0, 100);
}

int[] ArrayRes1 = Numbers;
int[] ArrayRes2 = Numbers;
int[] ArrayRes3 = Numbers;

// Вывод изначального массива
Console.Write("Изначальный массив: ");
foreach (int i in Numbers)
{
    Console.Write(i + " ");
}

// Метод пузырька
void BubbleSort(ref int[] Array)
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[i] > Array[j])
            {
                int t = Array[i];
                Array[i] = Array[j];
                Array[j] = t;
            }
        }
    }
}

// Сортировка выбором
void SelectionSort(ref int[] Array)
{
    for (int i = 0; i < Array.Length-1; i++)
    {
        int min = i;

        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] < Array[min])
            {
                min = j;
            }
        }

        if (min != i)
        {
            int t = Array[i];
            Array[i] = Array[min];
            Array[min] = t;
        }
    }
}

// Быстрая сортировка
void QuickSort(ref int[] Array, int Left = 0, int Right = 0)
{
    int i = Left;
    int j = Right;

    int x = Array[(Left + Right) / 2];

    do
    {
        while (Array[i] < x)
        {
            ++i;
        }

        while (Array[j] > x)
        {
            --j;
        }

        if (i <= j)
        {
            int t = Array[i];
            Array[i] = Array[j];
            Array[j] = t;
            i++;
            j--;
        }
    } while (i <= j);

    if (Left < j)
        QuickSort(ref Array, Left, j);
    if (i < Right)
        QuickSort(ref Array, i, Right);
}

// Вывод пузырька
Console.Write("\nМассив отсортированный пузырьком: ");
BubbleSort(ref ArrayRes1);

foreach (int i in ArrayRes1)
{
    Console.Write(i + " ");
}

// Вывод сортировкой выводом
Console.Write("\nМассив отсортированный выводом: ");
SelectionSort(ref ArrayRes2);

foreach (int i in ArrayRes2)
{
    Console.Write(i + " ");
}

// Вывод бысрой сортировкой
Console.Write("\nМассив отсортированный быстрой сортировкой: ");
QuickSort(ref ArrayRes3);

foreach (int i in ArrayRes3)
{
    Console.Write(i + " ");
}