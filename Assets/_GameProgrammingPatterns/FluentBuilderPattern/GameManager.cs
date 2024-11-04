using UnityEngine;

namespace FluentBuilderPattern
{
    public class GameManager : MonoBehaviour
    {
        private void Awake()
        {
            Enemy enemy = new Enemy.Builder()
                .WithType("Goblin")
                .WithMaxHealth(50)
                .WithDamage(50)
                .WithIsBoss(false)
                .Build();
        }
    }
}