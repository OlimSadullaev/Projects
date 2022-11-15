using System.Collections;

/*var c=0;
 c = int.Parse(Console.ReadLine());
 Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
 Console.Write($"{c,3}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");

 c = c % 31 + 1;
 Console.Write($"{c,4}");
for(int i = 0; i < 6; i++)
{
    c = c % 31 + 1;
    Console.Write($"{c,4}");
}*/

/*Hashtable numberNames = new Hashtable();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

foreach (DictionaryEntry de in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);*/

/*Stack<int> myStack = new Stack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);
// myStack.Contains(5);

foreach(var item in myStack)
    Console.WriteLine(item + ",");

foreach (var item in myStack)
    Console.Write(item + ","); //prints 4,3,2,1, 
/*Console.WriteLine("------------------------");
Console.WriteLine(myStack.Peek());
Console.WriteLine(myStack.Clear);*/
//---------------------------------
/*Hashtable numberNames = new Hashtable();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

//The following throws run-time exception: key already added.
//numberNames.Add(3, "Three"); 

foreach (DictionaryEntry de in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);*/
//----------------------------------
/*ArrayList arlist = new ArrayList();
// or 
var arrlist = new ArrayList(); // recommended 
*/

/*Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");
Console.WriteLine(person);
*/

/*var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
Console.WriteLine("Prime numbers less than 20: " +
                  "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
                  primes.Item1, primes.Item2, primes.Item3,
                  primes.Item4, primes.Item5, primes.Item6,
                  primes.Item7, primes.Rest.Item1);
Console.WriteLine(primes);*/

/*class DecendingComparer<TKey> : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return y.CompareTo(x);      ////SortedList with additional class 
    }
}

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, int> descSortedList = new SortedList<int, int>(new DecendingComparer<int>());
        descSortedList.Add(1, 1);
        descSortedList.Add(4, 4);
        descSortedList.Add(3, 3);
        descSortedList.Add(2, 2);

        for (int i = 0; i < descSortedList.Count; i++)
        {
            Console.WriteLine("key: {0}, value: {1}", descSortedList.Keys[i], descSortedList.Values[i]);
        }
    }
}*/


class Program
{
    static void Main(string[] args)
    {
        var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));

        SortedList<int, int> descSortedList = new SortedList<int, int>(descendingComparer);
        descSortedList.Add(1, 1);
        descSortedList.Add(4, 4);
        descSortedList.Add(3, 3);
        descSortedList.Add(2, 2);       //// without creating class sorted list descending order.

        for (int i = 0; i < descSortedList.Count; i++)
        {
            Console.WriteLine("key: {0}, value: {1}", descSortedList.Keys[i], descSortedList.Values[i]);
        }
    }
}