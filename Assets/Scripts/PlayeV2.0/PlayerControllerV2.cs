using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
    //Movimiento
     private Vector3 playerMovementInput;
     public Rigidbody playerRB;
     public float Speed;

    //Daño al paciente

    public int patientHP; //vida del paciente 
    public bool patientDamage; //bool para saber si le haces daño al paciente (si la pones en true ejecutas la función de daño al paciente)

    //Daño al jugador
    public int vidas; //vidas del jugador 
    public bool playerDamage; //bool para saber si le haces daño al jugador (si la pones en true ejecutas la función de recibir daño)
    public bool canTakeDamage; //bool para determinar si puede recibir daño el jugador

    // Start is called before the first frame update
    void Start()
    {
        
        patientHP = 10; //vida del paciente valor inicial
        vidas = 6;      // vida del jugador valor inicial
        canTakeDamage = true;

    }

    private void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();

        PatientDamage(); //Llamar a la función para que el paciente reciba daño
        PlayerDamage();  //Llamar a la función para que el player reciba daño
    }

    public void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
        playerRB.velocity = new Vector3(MoveVector.x, playerRB.velocity.y, MoveVector.z);
    }

    //Colisiones 

    private void OnTriggerEnter(Collider other)
    {
        //Hacer daño al paciente con colisión

        if (other.CompareTag("ParedCuerpo"))
        {
            patientDamage = true;

            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));
        }

        //Hacer daño al jugador con colisión

        if (other.CompareTag("Enemigo"))
        {
            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));

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
            patientHP = patientHP + 1;
            patientDamage = false;   //poner la bool en false para que no reciba daño infinito

            //Perder por daño al paciente

            if (patientHP == 18)
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
