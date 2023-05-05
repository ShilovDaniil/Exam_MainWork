// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[] {"smile", "Moscow", "txt", "Hi!", "7"};

void PrintArray(string[] array)
{
  Console.Write("Первый массив: [");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + "; ");
  }
  System.Console.WriteLine("]");
}

void PrintNewArray(string[] array)
{
  System.Console.Write("Второй массив: [");
  string[] newArray = new string[3];
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
    {
    System.Console.Write(array[i] + "; ");
    }
  }
  System.Console.WriteLine("]");
}

PrintArray(array);
PrintNewArray(array);