using UnityEngine;

namespace FactoryPattern
{
    public class ShortSword : IWeapon
    {
        public string name;
        public int damage;
        public float range;

        public ShortSword(string name, int damage, float range)
        {
            this.name = name;   
            this.damage = damage;
            this.range = range;
        }

        public void Attack()
        {
            Debug.Log("Short Sword Attack");
        }
    }
}