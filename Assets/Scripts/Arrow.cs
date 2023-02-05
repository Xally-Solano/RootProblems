using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform rootTransform;
    public Rigidbody arrowRB;

    private void Start()
    {
        arrowRB = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.LookAt(rootTransform);
        arrowRB.constraints = RigidbodyConstraints.FreezePosition;
    }
}
