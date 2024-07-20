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
    