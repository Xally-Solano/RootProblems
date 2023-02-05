using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 24f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float MinDistanceToEye = 10f;
    public Transform fireOrigin;
    public Vector3 fireDirection = new Vector3();
    public string playerTag = "Player";
    public string environmentTag = "ParedCuerpo";
    public string armaTag = "Arma";


    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {


        rb.velocity = fireDirection * speed;
        CalculateDistanceToEye();
    }

    private void CalculateDistanceToEye()
    {
        if (fireOrigin != null)
        {
            float distanceFromEye = Vector3.Distance(transform.position, fireOrigin.position);

            if (distanceFromEye >= MinDistanceToEye)
            {
                gameObject.SetActive(false);
            }
        }
        else if (fireOrigin == null)
        {
            return;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(environmentTag))
        {
            gameObject.SetActive(false);
        }

        else if (collision.gameObject.CompareTag(playerTag))
        {
            Debug.Log("Damage to player!");
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag(armaTag))
        {
            gameObject.SetActive(false);
        }
    }
}
