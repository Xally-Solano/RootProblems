using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOff : MonoBehaviour
{
    public Attack atack;
    PlayerControllerV2 playerControllerV2;

    private void Start()
    {
        atack = FindObjectOfType<Attack>();
        playerControllerV2 = FindObjectOfType<PlayerControllerV2>();
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
