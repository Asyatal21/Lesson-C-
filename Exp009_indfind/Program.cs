﻿int[] array = {1,3,5,12,12};

int n = array.Length;

int find = 12;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;

}