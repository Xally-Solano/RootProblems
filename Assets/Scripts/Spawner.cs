using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPatterns;  //lista de enemigos que puedes spawnear
    public PlayerControllerV2 playerControllerV2; //referencia al player controller

    public float timeBetweenEnemies; //tiempo que transcurre entre el spawn de cada objeto
    public float randomTimeIncrease; //permite aumentar la velocidad del spawn 
    public float increaseSpawn; //permite aumentar la velocidad del spawn 
    public float minSpawnTime; //tiempo minimo que debe esperarse entre cada spawn
    public float maxNumItems;

    public int rnd; //elemento a spawnear random entre los de la lista enemyPatterns
    public int lengthFP; //longitud de la lista enemyPatterns 
    public float timeWaitNew; //tiempo a esperar para spawnear de nuevo después de un spawn 
    public float itemSpawned; //número de objetos que han sido spawneados

    private void Awake()
    {
        timeWaitNew = timeBetweenEnemies + Random.Range(0, randomTimeIncrease); //El tiempo para spawnear enemigos está ligeramente randomizado
        lengthFP = enemyPatterns.Length; //La variable lengthFP es igual a la longitud de la lista enemyPatterns
    }

    private void Start()
    {
        playerControllerV2 = FindObjectOfType<PlayerControllerV2>(); //Localizar el player controller
    }

    private void Update()
    {
        //Detectar si se necesita generar otro enemigo con apoyo del script EnemyDamage y del player controller

        if (playerControllerV2.requireNewEnemy == true)  //Si se requiere un nuevo enemigo 
        {
            itemSpawned = itemSpawned - 1;               //Disminuye el número de objetos spawneados para poder spawnear uno más 
            playerControllerV2.requireNewEnemy = false;  //Ya no se requiere un nuevo enemigo 
        }

        //Condiciones para generar un enemigo 

        if (timeWaitNew <= 0 && (maxNumItems == 0 || maxNumItems > itemSpawned)) //Si el tiempo de espera para nuevo item es 0 || si el número máximo de items es menor de los que han aparecido
        {
            Launch(); //Ejecutar función lanzar

            if (increaseSpawn >= 0 && timeBetweenEnemies > minSpawnTime)  //Si el tiempo en el que se incrementa el spawn es menor o igual a 0 pero mayor que el tiempo mínimo de espera
            {
                timeBetweenEnemies -= increaseSpawn; //El tiempo entre enemigos es igual o menor a la velocidad de incremento del spawn 
            }

            timeWaitNew = timeBetweenEnemies; //El tiempo a esperar para spawnear un nuevo spawn es igual al tiempo entre enemigos

            if (randomTimeIncrease > 0f)      //Si el incremento de tiempo randomizado entre spawns es mayor a 0 
            {
                timeWaitNew += Random.Range(0, randomTimeIncrease);  //El tiempo de espera se randomiza usando el incremento random de tiempo 
            }

            if (timeWaitNew < minSpawnTime) //Si el tiempo de espera entre spawns es menor al tiempo minimo de espera
            {
                timeWaitNew = minSpawnTime; //Se iguala al tiempo minimo de espera 
            }
            
            itemSpawned += 1;      //Incrementar el número de objetos spawneados al spawnear uno nuevo
        }

        else

        {
            timeWaitNew -= Time.deltaTime; //Si no se randomiza nada entonces el tiempo de espera entre cada item es una cuenta regresiva de tiempo
        }
    }

   //Función para spawnear

    public void Launch()
    {
        rnd = Random.Range(0, lengthFP); //La variable rnd equivale a un objeto random de la longitud de la lista enemyPatterns
        Instantiate(enemyPatterns[rnd], transform.position, Quaternion.identity); //Se instancia el enemigo 
    }
}
