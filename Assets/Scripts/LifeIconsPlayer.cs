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
    public GameObject Heart6;
    public GameObject Heart7;
    public GameObject Heart8;
    public GameObject Heart9;
    public GameObject Heart10;
    public GameObject Heart11;


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
        if (g == 12)
        {
            Heart11.SetActive(true);
            Heart10.SetActive(true);
            Heart9.SetActive(true);
            Heart8.SetActive(true);
            Heart7.SetActive(true);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 11)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(true);
            Heart9.SetActive(true);
            Heart8.SetActive(true);
            Heart7.SetActive(true);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }

        if (g == 10)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(true);
            Heart8.SetActive(true);
            Heart7.SetActive(true);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 9)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(true);
            Heart7.SetActive(true);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 8)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(true);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 7)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(true);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 6)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(true);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 5)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(true);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 4)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(true);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 3)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(true);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 2)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(true);
            Heart.SetActive(true);
        }
        if (g == 1)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);
            Heart.SetActive(true);
        }
        if (g == 0)
        {
            Heart11.SetActive(false);
            Heart10.SetActive(false);
            Heart9.SetActive(false);
            Heart8.SetActive(false);
            Heart7.SetActive(false);
            Heart6.SetActive(false);
            Heart5.SetActive(false);
            Heart4.SetActive(false);
            Heart3.SetActive(false);
            Heart2.SetActive(false);
            Heart1.SetActive(false);
            Heart.SetActive(false);
        }
    }

}
