using System.Collections;
using UnityEngine;

namespace PrototypePattern
{
    public class EnemySpawner : MonoBehaviour
    {
        public Enemy goblinPrototype;
        public Enemy skeletonPrototype; 
        
        public void SpawnGoblin(Vector3 position)
        {
            Enemy newGoblin = goblinPrototype.Clone();
            newGoblin.transform.position = position;
        }

        public void SpawnSkeleton(Vector3 position)
        {
            Enemy newOrc = skeletonPrototype.Clone();
            newOrc.transform.position = position;
        }

        private void Awake()
        {
            StartCoroutine(SpawnEnemies());
        }

        private IEnumerator SpawnEnemies()
        {
            int spawnCount = 0;
            while (spawnCount < 10)
            {
                spawnCount++;
                int i = Random.Range(0, 2);
                if (i == 0) SpawnGoblin(Vector3.zero * Random.Range(0f, 5f));
                else if (i == 1) SpawnSkeleton(Vector3.zero * Random.Range(0f, 5f));
                yield return new WaitForSeconds(1);
            }
        }
    }
}
