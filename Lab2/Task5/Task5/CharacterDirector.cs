namespace Task5
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetName("Елайра Світлоносна")
                .SetGender("Жіноча")
                .SetHeight("Висока")
                .SetBodyType("Струнка")
                .SetHairColor("Золота")
                .SetEyeColor("Блакитні")
                .SetOutfit("Срібна броня")
                .AddToInventory("Меч світла")
                .AddToInventory("Щит надії")
                .AddDeed("Врятувала село від дракона")
                .AddDeed("Зцілила хворих")
                .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetName("Моргул Тінемор")
                .SetGender("Чоловіча")
                .SetHeight("Середній")
                .SetBodyType("Міцний")
                .SetHairColor("Чорна")
                .SetEyeColor("Червоні")
                .SetOutfit("Темний плащ")
                .AddToInventory("Посох проклять")
                .AddToInventory("Книга темряви")
                .AddDeed("Спалив місто")
                .AddDeed("Отруїв річку")
                .Build();
        }
    }

}
