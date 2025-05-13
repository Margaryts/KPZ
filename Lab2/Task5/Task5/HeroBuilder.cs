using System.Collections.Generic;
using Task5;

namespace Task5
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _hero = new Character { Alignment = "Good" };

        public ICharacterBuilder SetName(string name) { _hero.Name = name; return this; }
        public ICharacterBuilder SetGender(string gender) { _hero.Gender = gender; return this; }
        public ICharacterBuilder SetHeight(string height) { _hero.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _hero.BodyType = bodyType; return this; }
        public ICharacterBuilder SetHairColor(string color) { _hero.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { _hero.EyeColor = color; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _hero.Outfit = outfit; return this; }
        public ICharacterBuilder AddToInventory(string item) { _hero.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { _hero.Deeds.Add(deed); return this; }

        public Character Build() => _hero;
    }
}
