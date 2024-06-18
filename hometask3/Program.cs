// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Reverse(int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    Reverse(array, i - 1);
}

int[] array = { 7, 18, 3, 94, 32 };
Reverse(array, array.Length - 1);