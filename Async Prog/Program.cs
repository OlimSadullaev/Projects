using System.Text;

namespace asyncProg
{
    class Program
    {
        static string abc(string aaa)
        {
            return ($"your name is {aaa}");
        }

        /*static async void ContentToConsole()
        {
            string readFileTask = await ReadFileAsync("c:\\temp\\file.txt");

            Console.WriteLine("Fayldagi ma'lumotlar:" + readFileTask);
        }*/

        static void Main(string[] args)
        {
            string bbb = Console.ReadLine();
            abc(bbb);

            StringBuilder sbr = new StringBuilder("My Favourite Programming Font is ");
            sbr.Append("Inconsolata");
            Console.WriteLine(sbr);

        }
    }
}
