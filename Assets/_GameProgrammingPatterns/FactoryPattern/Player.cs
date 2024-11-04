using FactoryPattern;
using UnityEngine;

namespace FactoryPattern
{
    public class Player : MonoBehaviour
    {
        WeaponFactory weaponFactory;
        IWeapon currentWeapon;

        private void Awake()
        {
            weaponFactory = new WeaponFactory();
        }

        private void Start()
        {
            currentWeapon = weaponFactory.CreateWeapon(WeaponType.ShortSword, "A", 25, 1.5f);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                Attack();

            if (Input.GetMouseButtonDown(1))
                currentWeapon = weaponFactory.CreateWeapon(WeaponType.LongSword, "B", 34, 3f);
        }

        private void Attack()
        {
            currentWeapon.Attack();
        }
    }
}
