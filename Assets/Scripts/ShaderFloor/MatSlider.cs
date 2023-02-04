using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatSlider : MonoBehaviour
{
    private Material MSickness;

    public float Health = 0f;

    public GameObject floor;

    public GameObject player;
    private PlayerControllerV2 HumanHPScript;

    public HealthBarSickness healthBar;

    public float MaterialHealth = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;

        
        MSickness = floor.GetComponent<Renderer>().material;

        MSickness.SetFloat("_Health", 0f);

        HumanHPScript = player.GetComponent<PlayerControllerV2>();

        MaterialHealth = Health;

        //healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        
        Health = HumanHPScript.patientHP;

        float delta = Health - MaterialHealth;
        delta *= Time.deltaTime;
        MaterialHealth += delta;

        MSickness.SetFloat("_Health", MaterialHealth * 0.1f);

        healthBar.SetCurrentHealth(Health * 0.1f);

        //print(Health);

        /*
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
