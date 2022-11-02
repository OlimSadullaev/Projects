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

            float q = 5;
            kvadrad(q, out float yuza1, out float peremetr1, out float radius1);

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

            StringBuilder strB = new StringBuilder();
            StringBuilder stB = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                strB.Append("Salom ");
            }

            string str = " Yes ";

            strB.Append(str);
            Console.WriteLine(strB); //output:   Hello World!! Yes 


            strB.Remove(0, 11);

            Console.WriteLine(strB);
            //output: !!

            strB.Replace("World", "C#");

            Console.WriteLine(strB);
            //output: Hello C#!!

            Console.WriteLine(strB); //output: Hello World!!
            strB.Clear();
            Console.WriteLine(strB);

            StringBuilder sb = new StringBuilder("Hello World!");
            sb.Insert(5, " C#");

            Console.WriteLine(sb);

            double s, a, x;
            try
            {
                Console.Write("a=");
                a = Double.Parse(Console.ReadLine()); Console.Write("x=");

                x = Double.Parse(Console.ReadLine());

                s = (a * a + Math.Exp(2 * a - 6)) / (x * (a + Math.Pow(2, x)));

                Console.WriteLine("s=" + s);
            }
            catch (SystemException ex)
            {
                Console.WriteLine("Ifodaning qiymatini hisoblashda" + ex.Message + " xatolik yuz berdi");
            }
            finally
            {
                Console.WriteLine("Ifodaning qiymatini hisoblash tugadi");
            }
            Console.ReadLine();
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
