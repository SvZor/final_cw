using System;
class Programm
{
    static void Main()
    {
        string[] array1 = { "Hello", "2", "world", ":-)" };
        string[] array2 = { "1234", "1567", "-2", "computer science"};
        string[] array3 = { "Russia", "Denmark", "Kazan"};

        // запуск функции для фильтрации каждого примера
        string[] result1 = FiltrArray(array1);
        string[] result2 = FiltrArray(array2);
        string[] result3 = FiltrArray(array3);

        // вывод результатов 
        Console.WriteLine("[" + string.Join(", ", array1) + "] → [" + string.Join(", ", result1) + "]");
        Console.WriteLine("[" + string.Join(", ", array2) + "] → [" + string.Join(", ", result2) + "]");
        Console.WriteLine("[" + string.Join(", ", array3) + "] → [" + string.join(", ", result3) + "]");
    }
    static string[] FilterArray(string[] inputArray)
    {
        // Подсчёт количества строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }
        // Создание нового массива нужного размера
        string[] resultArray = new string[count];

        // Заполнение нового массива строками, длина которых меньше или равна 3 символам
        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}
