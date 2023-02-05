using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnCount : MonoBehaviour
{

    private GameObject player;
    private PlayerControllerV2 HumanHPScript;
    public float valorenfemmedad = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Robotson");

        HumanHPScript = player.GetComponent<PlayerControllerV2>();

        HumanHPScript.patientHP = HumanHPScript.patientHP + valorenfemmedad;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
