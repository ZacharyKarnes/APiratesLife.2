using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawn : MonoBehaviour
{
    public GameObject rsheathedWeapon;
    public GameObject rheldWeapon;

    public void DrawSword()
    {
        rsheathedWeapon.SetActive(false);
        rheldWeapon.SetActive(true);
    }
}
