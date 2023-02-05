using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOnce : MonoBehaviour
{
    public GameObject[] enemyPatterns;  //lista de enemigos que puedes spawnear
    //public PlayerControllerV2 playerControllerV2; //referencia al player controller

    public int SpawnNumber = 5;

    public int rnd; //elemento a spawnear random entre los de la lista enemyPatterns
    public int lengthFP; //longitud de la lista enemyPatterns 


    private void Awake()
    {

        lengthFP = enemyPatterns.Length; //La variable lengthFP es igual a la longitud de la lista enemyPatterns
    }

    private void Start()
    {
        //playerControllerV2 = FindObjectOfType<PlayerControllerV2>(); //Localizar el player controller

        for (int repeat = 0; repeat < SpawnNumber; repeat++)
        {
            //InvokeRepeating("Launch", 0f, 0.3f);
            Launch();
        }
        

    }

    private void Update()
    {

    }

   //Función para spawnear

    public void Launch()
    {
        rnd = Random.Range(0, lengthFP); //La variable rnd equivale a un objeto random de la longitud de la lista enemyPatterns
        Instantiate(enemyPatterns[rnd], transform.position, Quaternion.identity); //Se instancia el enemigo 
    }
}
