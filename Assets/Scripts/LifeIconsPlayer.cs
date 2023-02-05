using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIconsPlayer : MonoBehaviour
{
    //public GameObject[] iconsHP; //Objeto que va a contener los iconos
    //public Queue<GameObject> iconsQueue = new Queue<GameObject>(); //Crear lista para los iconos
    //public static LifeIconsPlayer iconsHPS; //Para hacer referencia a los iconos al recibir daño

    public GameObject Heart;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;

    public void Start()
    {
        
        //iconsHPS = this; //Le dices que tome la variable del objeto con este script
        /*
        //Por cada objeto en la lista de iconos lo aparece y lo pone en la cola

        foreach (GameObject g in iconsHP)
        {
            iconsQueue.Enqueue(g);
            g.gameObject.SetActive(true);
        }*/
    }

    //Funcion para reducir el numero de iconos en la cola y desaparecerlos (es la que llamas en donde vas a quitar vidas)

    public void reduceIcons()
    {
        /*
        GameObject g = iconsQueue.Dequeue();
        g.gameObject.SetActive(false);
        iconsQueue.Enqueue(g);

        iconsHP = GameObject.FindObjectsOfType<GameObject>();
        if (iconsHP.Length > 0)
        {
            int lastIndex = iconsHP.Length - 1;
            iconsHP[lastIndex].SetActive(false);
        }*/
    }

    public void addIcons(int g)
    {
        /*
        for (int i = 0; i < g; i++)
        {
            //iconsQueue.Enqueue(i);
            //i.gameObject.SetActive(true);

            iconsHP[i].SetActive(true);

            /*foreach (GameObject h in iconsHP)
            {
                iconsQueue.Enqueue(h);
            }
        }*/
                
        
    }

    public void changelife(int g)
    {
        if (g == 6)
        {
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 5)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 4)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 3)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 2)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 1)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);
            Heart.SetActive(true);
        }
        if (g == 0)
        {
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);
            Heart.SetActive(false);
        }
    }

}
