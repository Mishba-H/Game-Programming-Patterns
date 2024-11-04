using UnityEngine;

namespace FactoryPattern
{
    public interface IWeapon
    {
        void Attack();

        static IWeapon CreateDefaultWeapon()
        {
            return new ShortSword("its not short, this is average", 3, 0.3f);
        }
    }
}