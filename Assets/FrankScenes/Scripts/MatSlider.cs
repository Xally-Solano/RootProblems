using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatSlider : MonoBehaviour
{
    private Material MSickness;

    public float Health = 0f;

    public GameObject floor;

    //private HumanHealth Healthy;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        /*
        MSickness = GetComponent<Renderer>().material;

        MSickness.SetFloat("_Health", 0f);

        Health = floor.GetComponent<HumanHealthy>();
        */
 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Health = Healthy.HumanHealth;

        MSickness.SetFloat("_Health", Health * 0.1f);

        print(Health);

        if (Health >= 1f)
        {
            Perder();
        }
        
    }

    public void Perder()
    {
        Time.timeScale = 0f;
        SceneManager.LoadScene("SampleScene");

        */

    }

}
