//Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] arr = new int [8];// создаём массив с 8 переменными
static void massRandom(int[] arr)
{
Random rand = new Random(); // присваиваем команду rand
   
    for (int i =0;i<arr.Length;i++) // стандартный перебор for
    {
        arr[i] = rand.Next(0,100);//Заполняем случайными числами диапозоном от 0 до 100
    }
}
static void PrintArray(int[] array)// создаём метод вывода на экран
{
    int count = array.Length; // привыкаем,чтобы не путаться

    for (int i = 0; i < count; i++)// стандартный перебор for
    {
        Console.Write ($"{array[i]} ");// запись каждого элемента массива в квадратных скобках
    }
    Console.WriteLine();// пустая строка
} 
massRandom(arr);// применяем метод массива с 8 переменными
PrintArray(arr);// применяем метод выведения на экран массива
