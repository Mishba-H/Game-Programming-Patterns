using UnityEngine;

namespace FactoryPattern
{
    public class LongSword : IWeapon
    {
        public string name;
        public int damage;
        public float range;

        public LongSword(string name, int damage, float range)
        {
            this.name = name;
            this.damage = damage;
            this.range = range;
        }

        public void Attack()
        {
            Debug.Log("Long Sword Attack");
        }
    }
}