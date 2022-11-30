// Დაწერეთ პროგრამა რომელიც დააბრუნებს მასივში x-დან y შუალედში ელემენტებს.
using System;

int[] collection = new int[10] { 1, 3, 5, 7, 9, 6, 12, 4, 2, 10};

int x = 2, y = 5;

var res =
    from c in collection
   where c > x
   where c < y
  select c;

foreach (var a in res)
{
    Console.WriteLine(a);
}

