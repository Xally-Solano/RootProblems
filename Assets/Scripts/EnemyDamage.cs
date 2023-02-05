using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyHP; //Vida del enemigo
    public bool enemyDamage; //Bool para saber si dañas al enemigo
    PlayerControllerV2 playerController; //referencia al player controler

    public float valorenfemmedad = 0.3f;

    [SerializeField] GameObject stain;

    // Start is called before the first frame update
    void Start()
    {
        
        playerController = FindObjectOfType<PlayerControllerV2>(); //encontral el script del player controler 
    }

    // Update is called once per frame
    void Update()
    {
        ReduceEnemyHP(); //Llamar a la función para reducir vida del enemigo
    }

    //Colisiones

    private void OnTriggerEnter(Collider collision)
    {
        //Hacer daño al enemigo con el arma y no recibir daño del enemigo si lo tocas con el arma

        if (collision.CompareTag("Arma"))
        {
            enemyDamage = true;
        }
    }

    //Función para reducir la vida del enemigo 

    public void ReduceEnemyHP()
    {
        if (enemyDamage == true) 
        {
            enemyHP = enemyHP - 1;
            enemyDamage = false;

            if (enemyHP == 0) //Si la vida del enemigo se reduce a  0
            {
                playerController.enemiesBeaten = playerController.enemiesBeaten + 1; //Aumenta el contador de enemiesBeaten del player controller

                playerController.patientHP = playerController.patientHP - valorenfemmedad; //reduce barra de enfermedad

                playerController.requireNewEnemy = true; //sE A

                Instantiate(stain, transform.position, Quaternion.Euler(90, 0, 0));
                Destroy(gameObject);
            }
        }
    }


}
