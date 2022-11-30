//Დაწერეთ პროგრამა რომელიც სტრინგში (წინადადებაში იპოვნის uppercase-იან სიტყვბს და დაბეჭდავს მათ)
using System;

string s = "CHVEN GVAQVS erti didi PROEQTI";

var upperWords = s.Split(' ').Where(i => i == i.ToUpper()).ToList();

foreach (var word in upperWords)
{
    Console.WriteLine(word);
}