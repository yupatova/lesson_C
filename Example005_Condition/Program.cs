﻿Console.WriteLine("Введите имя пользоватея");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША");
}
else
{
Console.WriteLine("Привет, ");
Console.Write(username);
}