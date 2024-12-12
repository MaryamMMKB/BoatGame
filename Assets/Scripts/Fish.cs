using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour, IInteractable
{
    
    public void Interact()
    {
        Debug.Log("Fick En!");
        GameManager.Instance.AddFisk(1);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
