// Find the words in the collection that start with the letter 'L'
List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

IEnumerable<string> LFruits = from fruit in fruits
    where fruit.StartsWith("L")
    orderby fruit ascending
    select fruit;

foreach (string c in LFruits)
{
    Console.WriteLine($"{c}");
}
