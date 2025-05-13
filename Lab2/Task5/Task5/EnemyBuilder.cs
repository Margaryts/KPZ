using Task5;

namespace Task5
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _enemy = new Character { Alignment = "Evil" };

        public ICharacterBuilder SetName(string name) { _enemy.Name = name; return this; }
        public ICharacterBuilder SetGender(string gender) { _enemy.Gender = gender; return this; }
        public ICharacterBuilder SetHeight(string height) { _enemy.Height = height; return this; }
        public ICharacterBuilder SetBodyType(string bodyType) { _enemy.BodyType = bodyType; return this; }
        public ICharacterBuilder SetHairColor(string color) { _enemy.HairColor = color; return this; }
        public ICharacterBuilder SetEyeColor(string color) { _enemy.EyeColor = color; return this; }
        public ICharacterBuilder SetOutfit(string outfit) { _enemy.Outfit = outfit; return this; }
        public ICharacterBuilder AddToInventory(string item) { _enemy.Inventory.Add(item); return this; }
        public ICharacterBuilder AddDeed(string deed) { _enemy.Deeds.Add(deed); return this; }

        public Character Build() => _enemy;
    }
}
