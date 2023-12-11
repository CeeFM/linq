// // Find the words in the collection that start with the letter 'L'
// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

// IEnumerable<string> LFruits = from fruit in fruits
//     where fruit.StartsWith("L")
//     orderby fruit ascending
//     select fruit;

// foreach (string c in LFruits)
// {
//     Console.WriteLine($"{c}");
// }
// Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 | number % 6 == 0);

// IEnumerable<int> sortedMultiples = fourSixMultiples.OrderBy(n => n);
// foreach (int c in sortedMultiples)
// {
//     Console.WriteLine($"{c}");
// }
// Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>()
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(n => n).ToList();
// for (int i = 0; i < descend.Count; i++)
// {
// Console.WriteLine(descend[i]);
// }

// Build a collection of these numbers sorted in ascending order
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// List<int> sortedNums = numbers.OrderBy(n => n).ToList();

// for (int i = 0; i < sortedNums.Count; i++)
// {
// Console.WriteLine(sortedNums[i]);
// }

// Output how many numbers are in this list
// List<int> numbers = new List<int>()
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// int listLength = numbers.Count;
// Console.WriteLine(listLength);
// How much money have we made?
// List<double> purchases = new List<double>()
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// double total = 0.00;

// foreach (double c in purchases) {
//     total = total + c;
// }

// string s = total.ToString("N2");

// Console.WriteLine($"We have made ${s} money you hound dogs!!");
// What is our most expensive product?
// List<double> prices = new List<double>()
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

//  List<double> sortedNums = prices.OrderBy(n => n).ToList();
//  Console.WriteLine($"{sortedNums[sortedNums.Count - 1]} is our most expensive product price");

List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};
/*
    Store each number in the following List until a perfect square
    is detected.

    Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/

List<int> nonSquares = [];
List<int> squares = [];


// Console.WriteLine(doubleString.Contains("."));

for (int i=0; i < wheresSquaredo.Count; i++) {
string doubleString = Math.Sqrt(wheresSquaredo[i]).ToString();
    if (doubleString.Contains("."))
    {
        nonSquares.Add(wheresSquaredo[i]);
    }
    else
    {
        squares.Add(wheresSquaredo[i]);
        break;
    }
}

foreach (int nonsquare in nonSquares)
{
    Console.WriteLine(nonsquare);
}
