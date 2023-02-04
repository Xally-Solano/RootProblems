using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHP; //Vida del enemigo
    public bool enemyDamage; //Bool para saber si dañas al enemigo
    public PlayerController playerController; //referencia al player controler
    public float pushForce = 5f;
    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 3; //Valor inicial de la vida del enemigo
        playerController = FindObjectOfType<PlayerController>(); //encontral el script del player controler 
    }

    // Update is called once per frame
    void Update()
    {
        ReduceEnemyHP(); //Llamar a la función para reducir vida del enemigo
    }

    //Colisiones

    private void OnTriggerEnter(Collider other)
    {
        //Hacer daño al enemigo con el arma y no recibir daño del enemigo si lo tocas con el arma

        if (other.CompareTag("Arma"))
        {
            playerController.canTakeDamage = false; //bool del player controles que determina si puede recibir daño el jugador
            enemyDamage = true;

        }

        if (other.CompareTag("Player"))
        {
            

            other.transform.Translate(Vector3.right * playerController.horizontalMove);
            other.transform.Translate(Vector3.forward * playerController.verticalMove);
        }
    }

    //Cuando dejas de tocar al enemigo con el arma puedes recibir daño de nuevo

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Arma"))
        {
            playerController.canTakeDamage = true;

        }
    }

    //Función para reducir la vida del enemigo 

    public void ReduceEnemyHP()
    {
        if (enemyDamage == true)
        {
            enemyHP = enemyHP - 1;
            enemyDamage = false;

            if (enemyHP == 0)
            {
                Destroy(gameObject);
            }
        }
    }


}
