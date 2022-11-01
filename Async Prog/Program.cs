using Async_Prog_;
using System.Net.Security;
using System.Text;

namespace asyncProg
{


    /*static async void ContentToConsole()
    {
        string readFileTask = await ReadFileAsync("c:\\temp\\file.txt");

        Console.WriteLine("Fayldagi ma'lumotlar:" + readFileTask);
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            //int a = 8, b = 5;
            //swapp(ref a, ref b);

            //Console.WriteLine(a + "  " + b);
            //Console.ReadKey();

            //-------------------

            float a = 5;
            kvadrad(a, out float yuza1, out float peremetr1, out float radius1);

            Console.WriteLine(yuza1 + "  " + peremetr1 + " " + radius1);
            Console.ReadKey();

            int[] A = { 1, 4, 3, 1 };
            string[] B = { "olma", "gilos", "anor" };
            double[] C = { 0.005, 1.234, 12.5, 13.5, 10.6 };

            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            // Console.ReadLine(nums[3]);   //5
            int[,] nums1;
            int[,] nums2 = new int[2,3];
            int[,] nums3 = new int[2, 3] { { 0,1,2,}, { 3,4,5} };
            int[,] nums4 = new int[,] { { 0,1,2} };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
        }

        static void kvadrad(float a, out float yuza, out float peremetr, out float radius)
        {
            yuza = a * a;
            peremetr = 4 * a;
            radius = a / 2;
        }
        static void swapp(ref int a, ref int b)
        {
            int k = a;
            a = b;
            b = k;
        }
    }
    
    
}
