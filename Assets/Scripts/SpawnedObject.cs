using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    public float destroyAfter = 2.0f;
    public bool bePartOfPool = false;
    private Vector3 initialPos;

    private void Start()
    {
        if (bePartOfPool == true)
        {
            initialPos = transform.position;
            StartCoroutine(returnPositionOriginal(destroyAfter));
        }
        else
        {
            Destroy(gameObject, destroyAfter);
        }
    }

    public void DestroyObject()
    {
        if (bePartOfPool == true && destroyAfter > 0)
        {
            gameObject.transform.position = initialPos;
            gameObject.SetActive(false);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    IEnumerator returnPositionOriginal(float pTimeWait)
    {
        yield return new WaitForSeconds(pTimeWait);
        gameObject.transform.position = initialPos;
        gameObject.SetActive(false);
    }

}
