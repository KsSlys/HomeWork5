//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int num = 6;
int[] array = GetBinArray(num);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100,1000);
    }
    return result;
}
int count = 0;
for (int i = 0; i < array.Length; i++){
    
     if (array [i] % 2 == 0)
       count +=1;
}
Console.WriteLine($"Количество четных чисел -> {count}");