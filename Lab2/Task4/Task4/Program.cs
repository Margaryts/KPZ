class Program
{
    static void Main(string[] args)
    {
        Virus parent = new Virus("Alpha", "RNA", 1.2, 5);

        Virus child1 = new Virus("Beta", "RNA", 0.9, 2);
        Virus child2 = new Virus("Gamma", "RNA", 1.0, 3);
        Virus grandchild1 = new Virus("Delta", "RNA", 0.5, 1);

        child1.AddChild(grandchild1);   
        parent.AddChild(child1);
        parent.AddChild(child2);

        Console.WriteLine("Original Virus Family:");
        parent.Print();

        Virus clonedParent = (Virus)parent.Clone();
        Console.WriteLine("\nCloned Virus Family:");
        clonedParent.Print();
    }
}

