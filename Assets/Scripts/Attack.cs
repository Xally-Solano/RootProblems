using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject weapon;
    public Animator animator;
    public bool canAtack;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        weapon.SetActive(false);
        canAtack = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Atacar
        if (canAtack == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                weapon.SetActive(true);
                StartAtack();
            }
        }
        else
        {
            return;
        }
    }

    public void StartAtack()
    {
        animator.SetBool("AttackOn", true);
    }

}

