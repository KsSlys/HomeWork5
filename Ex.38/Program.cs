/*Зaдайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.Clear();
int[] array = GetBinArray(7, -99 , 100);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetBinArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int max = 0;


for ( int i = 0; i< array.Length; i++){
    if (array [i] > max) max = array [i];
}
int min = max;
for ( int i = 0; i< array.Length; i++){
    if (array [i] < min) min = array [i];
}
Console.WriteLine($"Разница между максимальным и минимальным значение = {max - min}");