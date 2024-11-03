using UnityEngine;

namespace FlyweightPattern
{
    public class LeafFlyweight
    {
        public Sprite sprite;
        public Color color;

        public LeafFlyweight(Sprite sprite, Color color)
        {
            this.sprite = sprite;
            this.color = color;
        }
    }
}
