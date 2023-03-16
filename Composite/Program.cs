namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1 = new File("file1.txt", 1024);
            var file2 = new File("file2.txt", 2048);

            var directory1 = new Directory("directory1");
            directory1.Add(file1);
            directory1.Add(file2);

            var file3 = new File("file3.txt", 4096);

            var directory2 = new Directory("directory2");
            directory2.Add(file3);
            directory2.Add(directory1);

            directory2.Display();
        }
    }
}