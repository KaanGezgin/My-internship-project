using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertMemoryFragment : MonoBehaviour
{
    [SerializeField] private GameObject memoryFragment;
    [SerializeField] private GameObject control1;
    [SerializeField] private GameObject control2;
    [SerializeField] private GameObject control3;
    [SerializeField] private GameObject control4;
    [SerializeField] private GameObject teleporter;
    void Start()
    {
        memoryFragment.SetActive(false);
        teleporter.SetActive(false);
    }
    void Update()
    {
        if(control1 == false && control2 == false && control3 == false && control4 == false)
        {
            memoryFragment.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            teleporter.SetActive(true);
        }
    }
}
