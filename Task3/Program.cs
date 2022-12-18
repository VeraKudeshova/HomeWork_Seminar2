// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
string a = Console.ReadLine();

if (a == "1")
{
    Console.WriteLine("Понедельник" + " " + "не выходной");
}
else if (a == "2")
{
    Console.WriteLine("Вторник" + " " + "не выходной");
}
else if (a == "3")
{
    Console.WriteLine("Среда" + " " + "не выходной");
}
else if (a == "4")
{
    Console.WriteLine("Четверг" + " " + "не выходной");
}
else if (a == "5")
{
    Console.WriteLine("Пятница" + " " + "не выходной");
}
else if (a == "6")
{
    Console.WriteLine("Суббота" + " " + "выходной");
}
else if (a == "7")
{
    Console.WriteLine("Воскресенье" + " " + "выходной");
}
else
{
    Console.WriteLine("Ошибка");
}

