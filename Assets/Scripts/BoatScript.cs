using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{

    public float turnSpeed = 200f; // hur snabbt b�ten roterar med cursor
    private Rigidbody rb;
    public float Speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; //L�ser cursor p� sk�rmen
        Cursor.visible = false; //g�mmer cursor
    }

    
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // om du trycker escapes l�ser du upp och visar cursor
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * Speed, ForceMode.Force); // r�r spelaren framm�t
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * Speed, ForceMode.Force); // transform forward fast minus
        }

        float mouseX = Input.GetAxis("Mouse X"); //L�ser av musens horisontella r�relse
        Quaternion rotation = Quaternion.Euler(0, mouseX * turnSpeed * Time.deltaTime, 0);
        rb.MoveRotation(rb.rotation * rotation); //applikerar rotation med rb
       
    }
    private void OnTriggerEnter(Collider other)  //Kolla efter IInteractables och interacta 
    {
        IInteractable interactable = other.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.Interact();
        }
    }
}
