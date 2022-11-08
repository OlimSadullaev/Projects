using System.Collections;
using System.IO;
using System.Text;
using System;
using System.ComponentModel;

namespace Streams
{
    class Program
    {
        public delegate void Print(int val);

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
            Console.WriteLine("Print delegati yordamida ekranga chiqarildi");
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
            Console.WriteLine("Action delegati yordamida ekranga chiqarildi");
        }
        //static Hashtable userInfoHash();
        static void Main(string[] args)
        {
            string date = "05/12/20143";
            Predicate<string> checkValidDate = d => IsDate(d);
            if (checkValidDate(date))
            {
                Console.WriteLine("Valid Date");
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
            Console.ReadKey();

            Func<int> GetRandomNum = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            //yoki
            Func<int, int, int> Sum = (x, y) => x + y;

            Print del_print = ConsolePrint;
            del_print(10);

            Console.ReadKey();
            Console.WriteLine("----------------");
            Action<int> act_print = ConsolePrint;
            act_print(101);

            Console.ReadKey();
            Console.WriteLine("--------------------");

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));


            userInfoHash abc = new Hashtable();
            
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
            }

            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }*/
             var movieDataManager = new MovieDataManager();
            var movies = movieDataManager.GetAllMovies();

             foreach(var movie in movies)
             {
                 Console.WriteLine(movie.Title);
             }

            FileStream F = new FileStream(@"C:\\Users\\user\\Desktop\\file\\salam.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Enter the text : ");

            string s = Console.ReadLine();
            byte []ascii = Encoding.ASCII.GetBytes(s);

            foreach(byte item in ascii)
            {
                F.WriteByte(item);
            };

            Console.Write("Data successfully written named as salam.txt");

            F.Close();
            Console.WriteLine("Press A to simulate a button click");
            var key = Console.ReadLine();
            if (key == "a")
            {
                KeyPressed();
            };
        }

        private static bool IsDate(string date)
        {
            DateTime dt;
            return DateTime.TryParse(date, out dt);
        }

        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
            {
                Console.WriteLine($"You clicked a button{args.Name}");
            };

            button.OnClick();
        }
    }

    public class Button
    {
        public EventHandler<MyCustomArguments> ClickEvent;
        public void OnClick()
        {
            MyCustomArguments myArgs = new MyCustomArguments();
            myArgs.Name = "Ian";
            ClickEvent.Invoke(this, myArgs);
        }
    }

    public class MyCustomArguments : EventArgs
    {
        public string Name { get; set; }
    }
}
