using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyDashAttack : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;
    public float dashSpeed = 20f;
    public float dashDistance = 10f;
    public float dashDuration = 1f;
    public float coolDown = 5f;
    private float dashTime;
    private float nextAttack;
    private bool isDashing = false;

    private void Awake()
    {
        player = FindObjectOfType<PlayerControllerV2>().gameObject.transform;
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        dashTime = dashDuration;
        nextAttack = coolDown;
        
    }

    private void Update()
    {
        if(player != null)
        {
            setDistance();
        }
    }

    void setDistance()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= dashDistance && !isDashing && nextAttack <= 0)
        {
            StartCoroutine(Dash());
        }
        else
        {
            nextAttack -= Time.deltaTime;
            agent.SetDestination(player.position);
        }
    }

    IEnumerator Dash()
    {
        isDashing = true;
        agent.speed = dashSpeed;
        agent.SetDestination(player.position);

        while (dashTime > 0)
        {
            dashTime -= Time.deltaTime;
            yield return null;
        }

        dashTime = dashDuration;
        agent.speed = 3f;
        isDashing = false;
        nextAttack = coolDown;
    }
}
