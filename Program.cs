namespace GenericConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myObject = new Classes.GenericClass<string, int>("Hello", 123, 7, "Test");

            myObject.ShowFields();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
