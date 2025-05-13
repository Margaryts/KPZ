using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " with Armor";
        public override int GetPower() => _hero.GetPower() + 3;
    }
    public class WeaponDecorator : HeroDecorator
    {
        public WeaponDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " with Weapon";
        public override int GetPower() => _hero.GetPower() + 5;
    }

    public class ArtifactDecorator : HeroDecorator
    {
        public ArtifactDecorator(IHero hero) : base(hero) { }

        public override string GetDescription() => _hero.GetDescription() + " with Artifact";
        public override int GetPower() => _hero.GetPower() + 7;
    }

}
