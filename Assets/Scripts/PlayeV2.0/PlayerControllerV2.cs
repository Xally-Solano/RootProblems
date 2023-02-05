using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControllerV2 : MonoBehaviour
{
    //Movimiento
     private Vector3 playerMovementInput;
     public Rigidbody playerRB;
     public float Speed;

    //Audio 
     AudioSource playerAudio;
     public AudioClip hitToPlayer;
     public AudioClip hitToPatient;

    //Dano al paciente

    public float patientHP; //vida del paciente // numero de enemigos spawneados

    public bool patientDamage; //bool para saber si le haces da?o al paciente (si la pones en true ejecutas la funci?n de da?o al paciente)

    //Spawnear enemigos si se destruye uno
    public int enemiesBeaten;
    public bool requireNewEnemy;

    //Salud del jugador
    public int vidas;
    public bool playerDamage;
    public LifeIconsPlayer lifeIconsPlayer;

    public int NumEnemiesHealthUP;

    // Start is called before the first frame update
    void Start()
    {
        
        patientHP = 0f; //vida del paciente valor inicial
        requireNewEnemy = false;
        lifeIconsPlayer = FindObjectOfType<LifeIconsPlayer>();
        playerAudio = GetComponent<AudioSource>();

    }

    private void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();

        PatientDamage(); //Llamar a la funcion para que el paciente reciba da?o
        PlayerDamage();

        if (patientHP >= 18)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("LOOSESCREEN");
        }

        if (enemiesBeaten % NumEnemiesHealthUP == 0 && vidas < 6 && vidas > 0)
        {
            vidas = vidas +1;
            enemiesBeaten = enemiesBeaten + 1;
            lifeIconsPlayer.changelife(vidas);
        }

    }

    public void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
        playerRB.velocity = new Vector3(MoveVector.x, playerRB.velocity.y, MoveVector.z);
    }

    //Colisiones 

    private void OnTriggerEnter(Collider other)
    {
        //Hacer dano al paciente con colision

        if (other.CompareTag("ParedCuerpo"))
        {
            patientDamage = true;

            playerAudio.PlayOneShot(hitToPatient, 0.1f);

            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));
        }

        //Hacer da?o al jugador con colision

        if (other.CompareTag("Enemigo"))
        {
            this.transform.Translate(Vector3.right * -(Input.GetAxis("Horizontal")));
            this.transform.Translate(Vector3.forward * -(Input.GetAxis("Vertical")));

            playerAudio.PlayOneShot(hitToPlayer, 0.1f);

            playerDamage = true;
        }
    }

    //Funcion para el dano del paciente 

    public void PatientDamage()
    {
        if (patientDamage == true)
        {
            patientHP = patientHP + 1;
            patientDamage = false;   //poner la bool en false para que no reciba da?o infinito

            //Perder por da?o al paciente

            if (patientHP >= 18)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("LOOSESCREEN");
            }
        }
    }


    public void PlayerDamage()
    {
        
            if (playerDamage == true)
            {
                vidas = vidas - 1;
                lifeIconsPlayer.changelife(vidas);
                playerDamage = false;
            }

        if (vidas <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("LOOSESCREEN");
        }
    }


}
