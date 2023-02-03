using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
    //Movimiento
     private Vector3 playerMovementInput;
     public Rigidbody playerRB;
     public float Speed;

    //Da�o al paciente

    public int patientHP; //vida del paciente 
    public bool patientDamage; //bool para saber si le haces da�o al paciente (si la pones en true ejecutas la funci�n de da�o al paciente)

    //Da�o al jugador
    public int vidas; //vidas del jugador 
    public bool playerDamage; //bool para saber si le haces da�o al jugador (si la pones en true ejecutas la funci�n de recibir da�o)
    public bool canTakeDamage; //bool para determinar si puede recibir da�o el jugador

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

        PatientDamage(); //Llamar a la funci�n para que el paciente reciba da�o
        PlayerDamage();  //Llamar a la funci�n para que el player reciba da�o
    }

    public void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
        playerRB.velocity = new Vector3(MoveVector.x, playerRB.velocity.y, MoveVector.z);
    }

    //Colisiones 

    private void OnTriggerEnter(Collider other)
    {
        //Hacer da�o al paciente con colisi�n

        if (other.CompareTag("ParedCuerpo"))
        {
            patientDamage = true;

            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));
        }

        //Hacer da�o al jugador con colisi�n

        if (other.CompareTag("Enemigo"))
        {
            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));

            if (canTakeDamage == true) //Si puede recibir da�o recibe da�o
            {
                playerDamage = true;
            }
            else //Si no puede recibir da�o entonces no recibe da�o
            {
                return;
            }
        }
    }

    //Funci�n para el da�o del paciente 

    public void PatientDamage()
    {
        if (patientDamage == true)
        {
            patientHP = patientHP + 1;
            patientDamage = false;   //poner la bool en false para que no reciba da�o infinito

            //Perder por da�o al paciente

            if (patientHP == 18)
            {
                Destroy(gameObject);
            }
        }
    }

    //Funci�n para el da�o del jugador 

    public void PlayerDamage()
    {
        if (playerDamage == true)
        {
            vidas = vidas - 1;
            playerDamage = false;  //poner la bool en false para que no reciba da�o infinito

            if (LifeIconsPlayer.iconsHPS != null)   //Si la lista de �conos de vida del player no est� vac�a
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
