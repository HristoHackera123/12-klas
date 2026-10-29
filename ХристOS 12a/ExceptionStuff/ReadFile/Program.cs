namespace ReadFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
            catch(ArgumentException argEx)
            {
                Console.WriteLine("No file typed");
            }
            catch(FileNotFoundException fileEx)
            {
                Console.WriteLine("File doesnt exist");
            }
        }
    }
}
