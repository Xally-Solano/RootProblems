using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOff : MonoBehaviour
{
    public Attack atack;

    private void Start()
    {
        atack = FindObjectOfType<Attack>();
    }

    void Update()
    {
    }

    public void EndAtack()
    {
        atack.canAtack = true;
        atack.weapon.SetActive(false);
    }
}
