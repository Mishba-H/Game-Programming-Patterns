using UnityEngine;

namespace FlyweightPattern
{
    public class LeafParticleSystem : MonoBehaviour
    {
        public Sprite[] LeafSprites;
        public Color[] LeafColors;
        public int LeafCount = 100;

        private LeafFlyweightFactory _flyweightFactory = new LeafFlyweightFactory();

        void Start()
        {
            for (int i = 0; i < LeafCount; i++)
            {
                SpawnLeaf();
            }
        }

        private void SpawnLeaf()
        {
            // Randomly pick a texture and color
            Sprite sprite = LeafSprites[Random.Range(0, LeafSprites.Length)];
            Color color = LeafColors[Random.Range(0, LeafColors.Length)];

            // Get or create the shared flyweight data
            LeafFlyweight flyweight = _flyweightFactory.GetFlyweight(sprite, color);

            // Create a new leaf particle with unique position and rotation
            GameObject leafObject = new GameObject("LeafParticle");
            LeafParticle leaf = leafObject.AddComponent<LeafParticle>();
            leaf.Initialize(flyweight,
                new Vector3(Random.Range(-5f, 5f), Random.Range(0f, 5f), Random.Range(-5f, 5f)),
                Quaternion.Euler(Random.Range(0, 360f), Random.Range(0, 360f), Random.Range(0, 360f)));
        }
    }
}