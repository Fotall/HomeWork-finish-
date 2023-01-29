public static class HomeWorkfinish
{
    public static void ex01()
    {
        string[] Array = { "Hello", "2", "Hello", ":-)" };

        int Limit = 3;
        for (int i = 0; i < Array.Length; i++)
            if (Array[i].Length <= Limit)
                Console.WriteLine(Array[i]);
    }
    public static void ex02()
    {

        Console.Write("Введите количество элементов массива: ");
        int elements = int.Parse(Console.ReadLine());
        string[] Array = new string[elements];
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i}: ");
            Array[i] = Console.ReadLine();
        }
        Console.WriteLine("Вывод массива:");
        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine(Array[i]);
        }
        
        Console.Write("Введите лимит на кол-во символов элемента массива: ");
        int Limit = int.Parse(Console.ReadLine()); // вводим длину строки
        
        for (int i = 0; i < Array.Length; i++)
            if (Array[i].Length <= Limit)
                Console.WriteLine(Array[i]);
    }

}