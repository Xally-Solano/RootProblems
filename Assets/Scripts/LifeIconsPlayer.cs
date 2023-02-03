using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIconsPlayer : MonoBehaviour
{
    public GameObject[] iconsHP; //Objeto que va a contener los iconos
    public Queue<GameObject> iconsQueue = new Queue<GameObject>(); //Crear lista para los iconos
    public static LifeIconsPlayer iconsHPS; //Para hacer referencia a los iconos al recibir daño

    public void Start()
    {
        iconsHPS = this; //Le dices que tome la variable del objeto con este script

        //Por cada objeto en la lista de iconos lo aparece y lo pone en la cola

        foreach (GameObject g in iconsHP)
        {
            iconsQueue.Enqueue(g);
            g.gameObject.SetActive(true);
        }
    }

    //Funcion para reducir el numero de iconos en la cola y desaparecerlos (es la que llamas en donde vas a quitar vidas)

    public void reduceIcons()
    {
        GameObject g = iconsQueue.Dequeue();
        g.gameObject.SetActive(false);
        iconsQueue.Enqueue(g);
    }

}
