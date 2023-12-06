﻿using UnityEngine;
using System.Collections;
using System;

public class InteractionController : MonoBehaviour
{
    Action interactAction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IInteractable interactable))
        {
            interactAction = interactable.Interact;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out IInteractable interactable))
        {
            interactAction = null;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (interactAction != null)
            {
                interactAction();
            }
        }
    }
}

public interface IInteractable
{
    public void Interact();
}