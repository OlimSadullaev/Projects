using System.Text;

namespace asyncProg
{
    class Program
    {

        /*static async void ContentToConsole()
        {
            string readFileTask = await ReadFileAsync("c:\\temp\\file.txt");

            Console.WriteLine("Fayldagi ma'lumotlar:" + readFileTask);
        }*/

        static void Main(string[] args)
        {
            string bbb = Console.ReadLine();


            StringBuilder sbr = new StringBuilder("Hello ");
            sbr.Append("World");
            Console.WriteLine(sbr);

            StringBuilder sbbb = new StringBuilder("your full name is work on br");
            sbbb.Length = 5;
            Console.WriteLine(sbbb);

        }
    }
}
