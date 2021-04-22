using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawn : MonoBehaviour
{
    public GameObject rSheathedWeapon;
    public GameObject rHeldWeapon;
    public GameObject lSheathedWeapon;
    public GameObject lHeldWeapon;


    public void DrawSword()
    {
        rSheathedWeapon.SetActive(false);
        rHeldWeapon.SetActive(true);
    }

    public void DrawDagger() {
        lSheathedWeapon.SetActive(false);
        lHeldWeapon.SetActive(true);
    }
}
