class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк массива: ");
        int n = int.Parse(Console.ReadLine());

        string[] arr = new string[n];
        string[] newArr = new string[n];
        int count = 0;

        Console.WriteLine("Введите элементы массива: ");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
            if (arr[i].Length <= 3)
            {
                newArr[count] = arr[i];
                count++;
            }
        }

        Console.WriteLine("Новый массив: ");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(newArr[i]);
        }
    }
}