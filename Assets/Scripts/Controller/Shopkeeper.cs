using UnityEngine;
using System.Collections;

public class Shopkeeper : MonoBehaviour, IInteractable
{
    public GameObject shopView;

    public void Interact()
    {
        shopView.SetActive(true);
    }
}

