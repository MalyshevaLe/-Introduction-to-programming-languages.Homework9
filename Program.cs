//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""                     !!!!!!! пропустили цифру 5


/*string ListOfNumbers(int m, int n)
{
    if (m == n)
    {
        return n.ToString();
    }
    else
    {
        return m.ToString() + " " + ListOfNumbers(m+=1, n);
    }
}

Console.Write("Введите 1-ое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(ListOfNumbers(m,n));*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
    return m + SumNumbers(m+1, n);
}

Console.Write("Введите 1-ое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое значение: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел в заданном промежутке: "+SumNumbers(m,n));*/



//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


double AckermanFunction(double m, double n)
{
    if (m == 0) return n+1;   
    else if (n == 0) return AckermanFunction(m-1, 1);  
    else return AckermanFunction(m-1, AckermanFunction(m, n-1));   
    
    //return AckermanFunction(m, n);
}

Console.Write("Введите число m: ");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число n: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
double Ackerman = AckermanFunction(m,n);
Console.WriteLine($"Функция Аккермана = {Ackerman}");