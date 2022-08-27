/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.Write("Введите количество цифр М: ");
int size = int.Parse(Console.ReadLine());

int[] GetArray(int size)
{
int[] newArray = new int[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1}-е число: ");
        newArray[i] = int.Parse(Console.ReadLine());
    }
    return newArray;
}

int PositiveSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
            if (array[i] > 0) count++;
    }
    return count;
}

int[] myArray = GetArray(size);
int amount = PositiveSum(myArray);
Console.WriteLine($"Из введенного {size} количества цифр, {amount} больше 0");
