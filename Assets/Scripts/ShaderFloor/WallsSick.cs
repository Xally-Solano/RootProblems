using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsSick : MonoBehaviour
{

    //public GameObject wall;

    public Material WallMat;

    public GameObject floor;

    private Material WallSickness;

    public float floorSickness = 0f;

    private MatSlider FloorSickScript;


    // Start is called before the first frame update
    void Start()
    {

        //WallSickness = wall.GetComponent<Renderer>().material;

        FloorSickScript = floor.GetComponent<MatSlider>();
    }

    // Update is called once per frame
    void Update()
    {
        floorSickness = FloorSickScript.MaterialHealth;

        WallMat.SetFloat("_Health", floorSickness * 0.1f);

        //print(floorSickness);
    }
}
