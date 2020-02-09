using HeroesGame.Constant;
using HeroesGame.Implementation.Weapon;
using System;

namespace HeroesGame.Implementation.Hero
{
    public class Mage : BaseHero
    {
        public Mage() : base(new Staff())
        {
        }

        protected override void LevelUp()
        {
            this.Level++;

            this.Armor += HeroConstants.MageArmorPerLevel;
            this.MaxHealth += HeroConstants.MageMaxHealthPerLevel;
            this.Health = this.MaxHealth;

            this.Weapon.LevelUp();
        }

        public static implicit operator global::Moq.Mock<object>(Mage v)
        {
            throw new NotImplementedException();
        }
    }
}
