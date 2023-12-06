using UnityEngine;

public class TreeView : MonoBehaviour
{
    public GameObject aliveTree;
    public GameObject deadTree;

    public void ChopTree()
    {
        deadTree.SetActive(true);
        aliveTree.SetActive(false);
        GetComponent<Collider2D>().enabled = false;
    }
}