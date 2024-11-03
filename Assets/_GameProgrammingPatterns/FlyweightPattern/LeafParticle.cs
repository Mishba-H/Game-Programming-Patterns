using UnityEditor.SceneManagement;
using UnityEngine;

namespace FlyweightPattern
{
    public class LeafParticle : MonoBehaviour
    {
        private LeafFlyweight _flyweight;
        private Vector3 _position;
        private Quaternion _rotation;

        public void Initialize(LeafFlyweight flyweight, Vector3 position, Quaternion rotation)
        {
            _flyweight = flyweight;
            _position = position;
            _rotation = rotation;

            CreateLeafParticle();
        }

        private void CreateLeafParticle()
        {
            SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>();
            sr.sprite = _flyweight.sprite;
            sr.color = _flyweight.color;
            transform.position = _position;
            transform.rotation = _rotation;
        }
    }
}