namespace asyncProg
{
    class Program
    {
        static async Task<string> ReadFileAsync(string file)
        {
            string content = string.Empty;

            using (StreamReader reader = new StreamReader(file))
            {
                content = await reader.ReadToEndAsync();
            }

            return content;
        }

        static async void ContentToConsole()
        {
            string readFileTask = await ReadFileAsync("c:\\temp\\file.txt");

            Console.WriteLine("Fayldagi ma'lumotlar:" + readFileTask);
        }

        static void Main(string[] args)
        {
            Task task = new Task(ContentToConsole);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }
    }
}
