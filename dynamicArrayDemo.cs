using System;
using System.Collections.Generic;
namespace Examples{

public class DynamicArray<T>
{
private T[] buffer = new T[5];
private int itemCount;
public T this[int index]
{
set{
if(index >= buffer.Length)
{
Array.Resize(ref buffer, index + 1);
}

buffer[index] = value;
itemCount++;
}
get{
return buffer[index];
}
}

public void PrintArray()
{
Console.WriteLine(String.Join(" ", buffer));
}
}
public class Program{
public static void Main(){

DynamicArray<int> intArray = new DynamicArray<int>();
intArray[0] = 10;
intArray[1] = 20;
intArray[2] = 30;
intArray[3] = 40;
intArray[5] = 50;
intArray.PrintArray();
DynamicArray<float> floatArray = new DynamicArray<float>();
floatArray[0] = 10.5F;
floatArray[2] = 12.5F;
floatArray[3] = 13.5F;
floatArray[4] = 14.5F;
floatArray.PrintArray();

}
}

}

