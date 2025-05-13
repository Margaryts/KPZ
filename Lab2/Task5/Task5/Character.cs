using System;
using System.Collections.Generic;

namespace Task5
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Outfit { get; set; }
        public List<string> Inventory { get; set; } = new();
        public List<string> Deeds { get; set; } = new();
        public string Alignment { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"\n--- {Name} ({Alignment}) ---");
            Console.WriteLine($"Стать: {Gender}, Зріст: {Height}, Будова тіла: {BodyType}");
            Console.WriteLine($"Волосся: {HairColor}, Очі: {EyeColor}");
            Console.WriteLine($"Вбрання: {Outfit}");
            Console.WriteLine("Інвентар: " + string.Join(", ", Inventory));
            Console.WriteLine("Що зроблено: " + string.Join(", ", Deeds));
        }
    }
}
