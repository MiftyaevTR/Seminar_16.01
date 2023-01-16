// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int GetStepen (int A, int B)
{
    int res =1;
    for (int el =1; el<=B; el++)
    {
        res=res*A;
    }
    return res;
}

Console.Write("Просьба введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Просьба введите степень: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = GetStepen(num1,num2);
Console.WriteLine(result);
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum (int num)
{
    int sum =0;
    for (int el=0; num>0; el++)
    {
        sum=sum+num%10;
        num=(num-num%10)/10;
    }
    return sum;
}

Console.Write("Просьба введите число: ");
int number=Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);
Console.WriteLine(result);
*/
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[ ] CreateArray (int size)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Просьба ввести элемент номер {i} - ");
        int elements=Convert.ToInt32(Console.ReadLine());
        array[i]=elements;
    }
    return array;
}

void ShowArray ( int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Укажите размер массива: ");
int m =Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateArray(m);
ShowArray(newArray);
*/
// Random array
/*
int[ ] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void ShowArray ( int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int [] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);
*/
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[ ] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int GetSumMinus (int [ ] array)
{
    int sum =0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i]<0) sum += array[i];
    }
    return sum;
}

void ShowArray ( int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int [] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

int res=GetSumMinus(newArray);
Console.WriteLine(res);
*/
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int[] GetReverse (int[] array)
{
    for (int i =0; i<array.Length; i++)
        array[i]=array[i]*-1;
    return array;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

int[] resuls =GetReverse(newArray);
ShowArray(resuls);
*/
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

bool GetSearch (int[] array, int x)
{ 
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]==x) return true;
    }
    return false;
}   
   
void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int x =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a number: ");

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

Console.WriteLine(GetSearch(newArray,x));
*/
// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int GetCountFind (int[] array, int min_num, int max_num)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i]>=min_num && array[i]<=max_num) count++;
    return count;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input minnumber value of elements: ");
int min_num =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input maxnumber value of elements: ");
int max_num =Convert.ToInt32(Console.ReadLine());

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

int result = GetCountFind(newArray,min_num,max_num);
Console.WriteLine("Количество элементов: " +  result);
*/
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int GetCountChetnoe (int[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
        if (array[i]%2==0) count++;
    return count;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
int min =100;
int max =999;

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

int result = GetCountChetnoe(newArray);
Console.WriteLine("Количество чётных элементов в массиве: " +  result);
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreaterandomArray ( int size, int minValue, int maxValue)
{
    int [ ] array= new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int GetSumChetnoe (int[] array)
{
    int count = 0;
    for (int i = 2; i<array.Length; i+=2)
    count+=array[i];
    return count;
}

void ShowArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

int[] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);

int result = GetSumChetnoe(newArray);
Console.WriteLine("Сумма чётных элементов: " +  result);
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] CreaterandomArray ( int size, int minValue, int maxValue)
{
    double[] array= new double[size];
    for (int i=0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1)+ Math.Round((new Random().NextDouble()),2);
    return array;
}

double GetMaxMinDiffer (double[] array)
{
   int max=0;
   int min=0;
   for (int el=0; el<array.Length-1; el++)
   {
        if (array[el]>array[max]) max=el;
        if (array[el]<array[min]) min=el;
   }
   return array[max]-array[min];
}

void ShowArray ( double[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("input a number of elements: ");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min value of elements: ");
int min =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max value of elements: ");
int max =Convert.ToInt32(Console.ReadLine());

double [] newArray = CreaterandomArray(m, min, max);
ShowArray(newArray);
double result = GetMaxMinDiffer(newArray);
Console.WriteLine("Разницу между максимальным и минимальным элементом массива " +  result);
*/

