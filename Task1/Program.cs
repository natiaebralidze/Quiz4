//Დაწერეთ პროგრამა რომელიც მასივში დაითვლის თითოეული  ელემენტი რამდენჯერ გვხვდება
using System;

int[] n1 = new int[10] { 10, 41, 32, 32, 4, 45, 41, 10, 8, 10 };

var res = n1.GroupBy(x => x)
               .Select(x => new { Number = x.Key, Times = x.Count() })
               .ToList();

foreach (var m in res)
{
    Console.WriteLine(m);
}