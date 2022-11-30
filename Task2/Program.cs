//Დაწერეთ პროგრამა რომელიც დაითვლის სტრინგში თითოეული სიმბოლო რამდენჯერ გვხვდება.
using System;

string s = "racxa maxinji stringi";

Console.WriteLine(s);

var res = s.GroupBy(x => x)
               .Select(x => new { Symbol = x.Key, Times = x.Count() })
               .ToList();

foreach (var m in res)
{
    Console.WriteLine(m);
}