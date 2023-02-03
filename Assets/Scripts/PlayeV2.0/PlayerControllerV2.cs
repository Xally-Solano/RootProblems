using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerV2 : MonoBehaviour
{
     private Vector3 playerMovementInput;
     public Rigidbody playerRB;
     public float Speed;

    private void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();
    }

    public void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
        playerRB.velocity = new Vector3(MoveVector.x, playerRB.velocity.y, MoveVector.z);
    }
}
