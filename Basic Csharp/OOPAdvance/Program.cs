﻿
using Namespace;

Console.WriteLine("Hello, Faysal!");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(RandomNumberGenerator.Generate());
}

Person p = new Teacher(20);
Person q = new Student(30);

Console.WriteLine(p.Id);
Console.WriteLine(q.Id);