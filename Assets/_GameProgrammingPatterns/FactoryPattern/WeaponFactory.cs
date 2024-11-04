using UnityEngine;

namespace FactoryPattern
{
    public class WeaponFactory
    {
        public IWeapon CreateWeapon(WeaponType type, string name, int damage, float range)
        {
            if (type == WeaponType.ShortSword)
                return new ShortSword(name, damage, range);
            else if (type == WeaponType.LongSword)
                return new LongSword(name, damage, range);
            return IWeapon.CreateDefaultWeapon();
        }
    }
}
