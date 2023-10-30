// Сборник задач/тема 3/подтема 3.2/высокий уровень/вариант 6


// задача двусмысленная, мы не можем сказать что решение номер 1 неправильное, но и решение номер 2 тоже верное.
// Последовательность это числа идущие друг за другом с определённой периодичностью что в формуле Фибоначчи обозначается n(находится n = n2-n1).
// я думаю что если бы условие звучало бы "найти сумму положительных чисел", то тогда решение 2 было бы самым подходящим.



// решение 1
try
{
Console.WriteLine("Введите числа(для конца работы введите 0): ");
int num1 = 0; // основное число
int n = 0; // запоминание предедыщего числа для сравнения
int sum = 0; // сумма чисел
do
{
    if (num1 == 0) num1 = int.Parse(Console.ReadLine()); // взятие первого числа для дальнейшего сравнения 
    n = num1; 
    num1 = int.Parse(Console.ReadLine());
    if (num1 == (n + 1))
    {
        if (sum == 0) sum = n; // после сравнения через if сумме присваивается первое число для дальнейшего суммирования последовательности 
        sum += num1;
    }
    else if (num1 == 0) break;
} while (num1 != 0);
Console.WriteLine(sum);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


// решение 2
try
    {
    int sum = 0;
    int num;
    Console.WriteLine("Введите числа(для конца работы введите 0): ");
    while (true)
    {
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            continue;
        }
        else if (num == 0)
        {
            break;
        }
        sum += num;
    }

    Console.WriteLine("Сумма положительных чисел: " + sum);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
