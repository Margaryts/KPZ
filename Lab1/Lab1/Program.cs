using Lab1;

public class Program
{
    public static void Main()
    {
        Warehouse warehouse = new Warehouse();
        Product apple = new Product("Яблуко", new Money(1, 50, "UAH"));
        Product banana = new Product("Банан", new Money(2, 75, "UAH"));

        warehouse.AddProduct(apple);
        warehouse.AddProduct(banana);

        Console.WriteLine("До знижки:");
        warehouse.ShowInventory();

        Console.WriteLine("\nЗастосовуємо знижку на яблуко:");
        apple.ApplyDiscount(30);
        apple.Display();

        Console.WriteLine("\nПоточний склад після знижки:");
        warehouse.ShowInventory();

        Reporting report = new Reporting(warehouse);
        report.InventoryReport();
    }
}