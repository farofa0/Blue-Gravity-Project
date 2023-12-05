using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeView : MonoBehaviour
{
    public GameObject aliveTree;
    public GameObject deadTree;

    private HitPoints hitPoints;

    void Start()
    {
        hitPoints = new HitPoints(5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Chop");
        hitPoints.ApplyDamage(1);
        if (hitPoints.IsDead)
        {
            deadTree.SetActive(true);
            aliveTree.SetActive(false);
            GetComponent<Collider2D>().enabled = false;
        }
    }
}