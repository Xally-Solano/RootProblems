using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera cam;
    private Plane groundPlane;
    private float rayLength;
    void Start()
    {
        //asigna la cámara principal a la variable "cam" para tomarla de referencia para la posición del puntero
        cam = Camera.main;
        //crea un plano para detectar la posición del mouse en función de un rayo que lo tocará
        groundPlane = new Plane(Vector3.up, transform.position);
    }
    void Update()
    {
        // Crea un rayo desde la cámara hasta el puntero del mouse
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);

        // Si el rayo intersecta con el plano
        if (groundPlane.Raycast(camRay, out rayLength))
        {
            // Obtiene la posición del puntero del mouse en el plano
            Vector3 pointToLook = camRay.GetPoint(rayLength);
            // Hace que el objeto mire hacia el puntero del mouse
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }
    }
}
