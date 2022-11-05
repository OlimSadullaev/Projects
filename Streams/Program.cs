using System.IO;
using System.Text;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
           // var movieDataManager = new MovieDataManager();
            //var movies = movieDataManager.GetAllMovies();

           /* foreach(var movie in movies)
            {
                Console.WriteLine(movie.Title);
            }*/

            FileStream F = new FileStream(@"C:\\Users\\user\\Desktop\\file\\salam.txt", FileMode.OpenOrCreate);
            Console.WriteLine("Enter the text : ");

            string s = Console.ReadLine();
            byte []ascii = Encoding.ASCII.GetBytes(s);

            foreach(byte item in ascii)
            {
                F.WriteByte(item);
            }

            Console.Write("Data successfully written named as salam.txt");

            F.Close();
        }
    }
}
