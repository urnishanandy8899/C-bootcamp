using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
public static void Main()
{
// Creating and initializing
// the value in a dynamic list
List<int> myarray = new List<int>();
myarray.Add(23);
myarray.Add(1);
myarray.Add(78);
myarray.Add(45);
myarray.Add(543);

// Display the element of the list
Console.WriteLine("Elements are: ");
foreach(int value in myarray)
{
Console.WriteLine(value);
}

// Sort the elements of the list
myarray.Sort();

// Display the sorted element of list
Console.WriteLine("Sorted element");
foreach(int i in myarray)
{
Console.WriteLine(i);
}
}
}
