using UnityEngine;

namespace PrototypePattern
{
    public class Enemy : MonoBehaviour, ICloneable<Enemy>
    {
        public string enemyType;
        public int health;
        public float speed;
        public int attackPower;

        public Enemy Clone()
        {
            // Instantiate a new GameObject as a clone of this enemy
            Enemy clone = Instantiate(this);
            clone.name = this.name + "_Clone";
            return clone;
        }
    }
}
