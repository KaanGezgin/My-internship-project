using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestDialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialogue;
    [SerializeField] private Collider coll;
    private void Start()
    {
        dialogue.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dialogue.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            coll.enabled = false;

            dialogue.SetActive(false);
        }
    }
}
