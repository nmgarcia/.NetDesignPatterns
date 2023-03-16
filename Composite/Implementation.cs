namespace Composite
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class FileSystemComponent
    {
        protected string name;
        protected int size;

        public int Size { get { return size; } }
        public FileSystemComponent(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public abstract void Display();
    }

    /// <summary>
    /// Leaf
    /// </summary>
    public class File : FileSystemComponent
    {
        public File(string name, int size) : base(name, size)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"File: {name}, Size: {size} bytes");
        }
    }

    /// <summary>
    /// Composite/Node
    /// </summary>
    public class Directory : FileSystemComponent
    {
        private List<FileSystemComponent> components;

        public Directory(string name) : base(name, 0)
        {
            components = new List<FileSystemComponent>();
        }

        public override void Display()
        {
            Console.WriteLine($"Directory: {name}, Size: {size} bytes");

            foreach (var component in components)
            {
                component.Display();
            }
        }

        public void Add(FileSystemComponent component)
        {
            components.Add(component);
            size += component.Size;
        }

        public void Remove(FileSystemComponent component)
        {
            components.Remove(component);
            size -= component.Size;
        }
    }

}
