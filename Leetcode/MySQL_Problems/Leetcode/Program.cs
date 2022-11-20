using System.Collections;
using System.IO;
using System.Text;

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
}

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


/*class Program
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
}*/

/*SortedList<int, string> numberNames = new SortedList<int, string>();
numberNames.Add(3, "Three");
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(4, null);
numberNames.Add(10, "Ten");
numberNames.Add(5, "Five");
//Console.WriteLine(numberNames);

SortedList<int, string> numberNamess = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

Console.WriteLine("---Initial key-values--");

foreach (KeyValuePair<int, string> kvp in numberNames)
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

numberNames.Add(6, "Six");
numberNames.Add(2, "Two");
numberNames.Add(4, "Four");

Console.WriteLine("---After adding new key-values--");

foreach (var kvp in numberNames)
    Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
Console.ReadKey();*/

/*class Program
{
    static void WriteFile(string Filename)
    {
        FileStream fs = new FileStream(Filename, FileMode.Open, FileAccess.Write);

        if (fs.CanWrite)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("!!! Writing to the memory successfully finished !!! ");
            fs.Write(buffer, 0, buffer.Length);
        }

        fs.Flush();
        fs.Close();
    }

    static void ReadFile(string Filename)
    {
        FileStream fs = new FileStream(Filename, FileMode.Open,FileAccess.Read );
        if (fs.CanRead)
        {
            byte[] buffer = new byte[1024];
            int bytesread = fs.Read(buffer, 0, buffer.Length);

            Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesread));
        }
        

        fs.Close();
    }
    static void Main(string[] args)
    {
        string Filename = @"C:\Users\user\Desktop\New folder\Doc.txt.txt";

        ReadFile(Filename);

        WriteFile(Filename);


        

        Console.Read();
    }

    
} */

// FileInfo fi = new FileInfo(@"D:\DummyFile.txt");

//Open a file for Read\Write
//FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

//Create an object of StreamReader by passing FileStream object on which it needs to operates on
// StreamReader sr = new StreamReader(fs);

//Use the ReadToEnd method to read all the content from file
// string fileContent = sr.ReadToEnd();

//Close the StreamReader object after operation
// sr.Close();
// fs.Close();/*

// Data source
/*string[] names = { "Bill", "Steve", "James", "Mohan" };

// LINQ Query 
var myLinqQuery = from name in names
                  where name.Contains('a')
                  select name;

// Query execution
foreach (var name in myLinqQuery)
    Console.Write(name + " ");
Console.WriteLine();


string[] cars = { "Lamo", "Aston_Martin", "Charles", "Apple", "Alfa Romeo", "Alpina"};

var linq = from car in cars
           where car.Distinct().Contains('a')
           select car;
foreach (var car in linq)
    Console.Write(car + ' ');

Console.Read();*/

/*class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
    public int Rank { get; set; }
}tic void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        /*Student[] students = new Student[10];

        int i = 0;

        foreach (Student std in studentArray)
        {
            if (std.Age > 12 && std.Age < 20)
            {
                students[i] = std;
                i++;
            }
            Console.WriteLine();
        }*/

/*Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

// Use LINQ to find first student whose name is Bill 
Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();

// Use LINQ to find student whose StudentID is 5
Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();


IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

var result = from s in stringList
             where s.Contains("Tutorials")
             select s;
Console.WriteLine(result);
Console.WriteLine("----------------------");

IList<string> sttringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

// LINQ Method Syntax
var rresult = stringList.Where(s => s.Contains("Tutorials"));

//  delegate (Student s) { return s.Age > 12 && s.Age < 20; };
// s => s.Age > 12 && s.Age < 20;

}
}*/
/*class Program:

    List<Student> students = new List<Student>();
    students.Add(new Student { Id = 1, Name = "Ramesh", Rank = 1, Age = 39 });
    students.Add(new Student { Id = 2, Name = "Kapil", Rank = 1, Age = 32 });
    students.Add(new Student { Id = 3, Name = "Suresh", Rank = 2, Age = 45 });
    students.Add(new Student { Id = 4, Name = "Mahesh", Rank = 2, Age = 39 });

    var studentsOrderByRank = from student in students
                              orderby student.Rank, student.Age
                              select student;

    Console.WriteLine("Sorted Students:");
    foreach (var student in studentsOrderByRank)
    {
        Console.WriteLine(student.Name);
    }*/

/*Entities e = new Entities();
var empDetail = from emp in e.EmployeeMasters
                let dep = emp.DepartmentMaster == null ? "" : emp.DepartmentMaster.DepartmentCode
                select new Detail
                {
                    EmployeeId = emp.EmployeeId,
                    EmployeeCode = emp.EmployeeCode,
                    EmployeeName = emp.EmployeeName,
                    DepartmentCode = dep,
                };*/


/*IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
};

var orderByResult = from s in studentList
                    orderby s.StudentName
                    select s;

var orderByDescendingResult = from s in studentList
                              orderby s.StudentName descending
                              select s;*/
/*
IList<string> strList1 = new List<string>() {
    "One",
    "Two",
    "Three",
    "Four"
};

IList<string> strList2 = new List<string>() {
    "One",
    "Two",
    "Five",
    "Six"
};

var innerJoin = strList1.Join(strList2,
                      str1 => str1,
                      str2 => str2,
                      (str1, str2) => str1);
Console.WriteLine();

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int StandardID { get; set; }
}

public class Standard
{
    public int StandardID { get; set; }
    public string StandardName { get; set; }
}
class Program
{
        IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
        new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
        new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
        new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
        new Student() { StudentID = 5, StudentName = "Ron"  }
    };

        IList<Standard> standardList = new List<Standard>() {
        new Standard(){ StandardID = 1, StandardName="Standard 1"},
        new Standard(){ StandardID = 2, StandardName="Standard 2"},
        new Standard(){ StandardID = 3, StandardName="Standard 3"}
    };

    var innerJoin = studentList.Join(// outer sequence 
                          standardList,  // inner sequence 
                          student => student.StandardID,    // outerKeySelector
                          standard => standard.StandardID,  // innerKeySelector
                          (student, standard) => new  // result selector
                          {
                              StudentName = student.StudentName,
                              StandardName = standard.StandardName
                          });
}*/
