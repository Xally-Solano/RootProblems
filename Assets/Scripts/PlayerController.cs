using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Movimiento

    public float horizontalMove;  //para movimiento horizontal
    public float verticalMove;    //para movimiento vertical
    public CharacterController player; //para recibir el script
    float playerSpeed = 3; //velocidad
    public LifeIconsPlayer lifeIconsPlayer; //para meter el script que hace que bajen los iconos de vida
    public bool canTakeDamage; //bool para determinar si puede recibir daño el jugador


    //Daño al paciente

    public int patientHP; //vida del paciente 
    public bool patientDamage; //bool para saber si le haces daño al paciente (si la pones en true ejecutas la función de daño al paciente)

    //Daño al jugador
    public int vidas; //vidas del jugador 
    public bool playerDamage; //bool para saber si le haces daño al jugador (si la pones en true ejecutas la función de recibir daño)

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();  //asignar character controller

        patientHP = 10; //vida del paciente valor inicial
        vidas = 6;      // vida del jugador valor inicial
        canTakeDamage = true;

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal"); //vincular el movimiento con la direccion
        verticalMove = Input.GetAxis("Vertical"); //vincular el movimiento con la direccion
        PatientDamage(); //Llamar a la función para que el paciente reciba daño
        PlayerDamage();  //Llamar a la función para que el player reciba daño

    }

    private void FixedUpdate()
    {
        player.Move(new Vector3(horizontalMove, 0, verticalMove) * playerSpeed * Time.deltaTime); //vector de movimiento
    }

    //Colisiones 

    private void OnTriggerEnter(Collider other)
    {
        //Hacer daño al paciente con colisión

        if (other.CompareTag("ParedCuerpo"))
        {
            patientDamage = true;
        }

        //Hacer daño al jugador con colisión

        if (other.CompareTag("Enemigo"))
        {
            if (canTakeDamage == true) //Si puede recibir daño recibe daño
            {
                playerDamage = true;
            }
            else //Si no puede recibir daño entonces no recibe daño
            {
                return;
            }
        }
    }

    //Función para el daño del paciente 

    public void PatientDamage()
    {
        if (patientDamage == true)
        {
            patientHP = patientHP - 1;
            patientDamage = false;   //poner la bool en false para que no reciba daño infinito

            //Perder por daño al paciente

            if (patientHP == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //Función para el daño del jugador 

    public void PlayerDamage()
    {
        if (playerDamage == true)
        {
            vidas = vidas - 1;
            playerDamage = false;  //poner la bool en false para que no reciba daño infinito

            if (LifeIconsPlayer.iconsHPS != null)   //Si la lista de íconos de vida del player no está vacía
            {
                LifeIconsPlayer.iconsHPS.reduceIcons();   //Llama a la variable static del script de iconos de vida 
            }

            //Perder por vida del jugador 

            if (vidas == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
