// Დაწერეთ პროგრამა რომელიც დაბეჭდავს სტრინგში ყველაზე განმეორებად სიმბოლოს
string s = "Saboloo proeqtamde bolo davaleba!";

var query = s.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;

Console.Write(query);