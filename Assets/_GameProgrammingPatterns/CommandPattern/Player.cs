using UnityEngine;

namespace CommandPattern
{
    public class Player : MonoBehaviour
    {
        public void Move(Vector3 direction)
        {
            transform.position += direction;
        }
    }
}