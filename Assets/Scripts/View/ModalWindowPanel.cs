using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ModalWindowPanel : MonoBehaviour
{
    public TextMeshProUGUI txtText;

    public Button confirmButton;
    public Button cancelButton;

    private Action onConfirmAction;
    private Action onCancelAction;

    public void Confirm()
    {
        onConfirmAction?.Invoke();
        gameObject.SetActive(false);
    }

    public void Cancel()
    {
        onCancelAction?.Invoke();
        gameObject.SetActive(false);
    }

    public void ShowModalWindow(string text, Action confirmAction, Action cancelAction)
    {
        txtText.text = text;
        onConfirmAction = confirmAction;
        onCancelAction = cancelAction;

        gameObject.SetActive(true);
    }

}