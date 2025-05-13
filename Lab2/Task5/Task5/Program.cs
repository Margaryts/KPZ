using System;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            var director = new CharacterDirector();

            var heroBuilder = new HeroBuilder();
            var enemyBuilder = new EnemyBuilder();

            var hero = director.CreateHero(heroBuilder);
            var enemy = director.CreateEnemy(enemyBuilder);

            hero.ShowInfo();
            enemy.ShowInfo();
        }
    }
}
