using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{
    
    //The root "Enemy"
    public int rootHP;
    public bool rootDamage;

    public PlayerControllerV2 playerControllerV2; //referencia al player controller

    private void Start()
    {
        playerControllerV2 = FindObjectOfType<PlayerControllerV2>();
    }

    private void Update()
    {
        ReduceRootHP();
    }

    //Colisiones

    private void OnTriggerEnter(Collider other)
    {
        //Hacer daño al enemigo con el arma y no recibir daño del enemigo si lo tocas con el arma

        if (other.CompareTag("Arma"))
        {
            rootDamage = true;
        }
    }

    //Bajar vide de la raíz

    public void ReduceRootHP()
    {
        if (rootDamage == true)
        {
            rootHP = rootHP - 1;

            rootDamage = false;

            if (rootHP == 0) //Si la vida del enemigo se reduce a  0
            {
                Destroy(this.gameObject);

                //Lo que pasa cuando ganas va acá
            }
        }
    }
}
