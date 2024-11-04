using NUnit.Framework.Constraints;
using UnityEngine;

namespace FluentBuilderPattern
{
    public class Enemy : MonoBehaviour
    {
        public string type { get; private set; }
        public int maxHealth { get; private set; }
        public int damage { get; private set; }
        public bool isBoss { get; private set; }

        public class Builder
        {
            string type;
            int maxHealth;
            int damage;
            bool isBoss;

            public Builder WithType(string type)
            {
                this.type = type;
                return this;
            }

            public Builder WithMaxHealth(int maxHealth)
            {
                this.maxHealth = maxHealth; return this;
            }

            public Builder WithDamage(int damage)
            {
                this.damage = damage; 
                return this;
            }

            public Builder WithIsBoss(bool isBoss)
            {
                this.isBoss = isBoss; 
                return this;
            }

            public Enemy Build()
            {
                var enemy = new GameObject("Enemy").AddComponent<Enemy>();
                enemy.type = type;
                enemy.maxHealth = maxHealth;
                enemy.damage = damage;
                enemy.isBoss = isBoss;
                return enemy.GetComponent<Enemy>();
            }
        }
    }
}