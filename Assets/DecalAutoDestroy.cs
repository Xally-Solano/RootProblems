using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalAutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("selfDestroy", 4f);
    }

    void selfDestroy()
    {
        Destroy(this.gameObject);
    }
   
}
