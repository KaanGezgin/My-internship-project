using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenMemControl : MonoBehaviour
{
    [SerializeField] private GameObject teleport;
    void Start()
    {
        teleport.SetActive(false);    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            teleport.SetActive(true);
        }
    }
}
