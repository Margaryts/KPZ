using Task2;

class Program
{
    static void Main()
    {
        IHero hero = new Mage();
        hero = new ArmorDecorator(hero);
        hero = new WeaponDecorator(hero);
        hero = new ArtifactDecorator(hero);

        Console.WriteLine($"Герой: {hero.GetDescription()}");
        Console.WriteLine($"Сила: {hero.GetPower()}");

        IHero palladin = new Palladin();
        palladin = new ArmorDecorator(palladin);
        palladin = new ArmorDecorator(palladin); 
        palladin = new WeaponDecorator(palladin);

        Console.WriteLine($"\nГерой: {palladin.GetDescription()}");
        Console.WriteLine($"Сила: {palladin.GetPower()}");
    }
}