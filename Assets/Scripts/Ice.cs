using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ice : MonoBehaviour, IInteractable
{
    public void Interact()
    {
      Debug.Log("Slog i något!");
      GameManager.Instance.LoseHealth(1);
    }
   
}
