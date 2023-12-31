using UnityEngine;

public class UIController : MonoBehaviour
{
    public ModalWindowPanel modalWindowPanel;
    public GameObject shopPanel;

    public static UIController Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}