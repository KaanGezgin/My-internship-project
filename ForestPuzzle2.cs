using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestPuzzle2 : MonoBehaviour
{
    [SerializeField] private GameObject pathTrigger;
    [SerializeField] private GameObject path;
    [SerializeField] private GameObject path2;
    [SerializeField] private GameObject path3;
    private void OnTriggerEnter(Collider other)
    { 
        if(other.gameObject.tag == "Player")
        {
            path.SetActive(true);
            path2.SetActive(true);
            path3.SetActive(true);
        }  
    }
}
