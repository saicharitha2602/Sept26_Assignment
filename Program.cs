namespace Sept26_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\Charitha.Neelisetty\\OneDrive - Entain Group\\Documents\\sample.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This example adds content to existing file");
            Console.WriteLine("Text appended successfully!!!");
            sw.Close();
            fs.Close();


        }
    }
}
