﻿// Вид 1  Методы Ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор; Юсипов Талгат");
}
// Method1();


// Вид 2 Методы Ничего не возвращают, но принимают какие-то аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текс сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

// Method21(count: 4, msg: "Новый текст" );


// Вид 3 Не принимает аргументы но возвращает значение 

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
 //Console.WriteLine(year);





// Вид 4 Что-то принимают и что-то возвращают

string Method4 (int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
// string res = Method4(10, "a");
// Console.WriteLine(res);

// string Method4 (int count, string c)
// {
    
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
        
//     }
//     return result;
// }
// string res = Method4(10, "a");
// Console.WriteLine(res);

// Пример цикл в цикле таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}