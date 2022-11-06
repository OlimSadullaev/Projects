using System.Collections;
using System.IO;
using System.Text;
using System;
using System.ComponentModel;

namespace Streams
{
    class Program
    {
        static Hashtable userInfoHash();
        static void Main(string[] args)
        {
            userInfoHash abc = new Hashtable();
            
            for (int i = 0; i < 10; i++)
            {
                userInfoHash.Add(i, "user" + i);
            }

            if (userInfoHash.ContainsKey(0))
            {
                userInfoHash.Remove(0);
            }
            // var movieDataManager = new MovieDataManager();
            //var movies = movieDataManager.GetAllMovies();

            /* foreach(var movie in movies)
             {
                 Console.WriteLine(movie.Title);
             }*/

            /*FileStream F = new FileStream(@"C:\\Users\\user\\Desktop\\file\\salam.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Enter the text : ");

            string s = Console.ReadLine();
            byte []ascii = Encoding.ASCII.GetBytes(s);

            foreach(byte item in ascii)
            {
                F.WriteByte(item);
            }

            Console.Write("Data successfully written named as salam.txt");

            F.Close();*/
            Console.WriteLine("Press A to simulate a button click");
            var key = Console.ReadLine();
            if (key == "a")
            {
                KeyPressed();
            };
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
