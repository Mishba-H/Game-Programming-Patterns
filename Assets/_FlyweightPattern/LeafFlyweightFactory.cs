using System.Collections.Generic;
using UnityEngine;

namespace FlyweightPattern
{
    public class LeafFlyweightFactory
    {
        private Dictionary<string, LeafFlyweight> _flyweights = new Dictionary<string, LeafFlyweight>();

        public LeafFlyweight GetFlyweight(Sprite sprite, Color color)
        {
            string key = sprite.name + color.ToString();

            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new LeafFlyweight(sprite, color);
            }

            return _flyweights[key];
        }
    }
}