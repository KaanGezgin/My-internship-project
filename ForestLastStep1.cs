using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestLastStep1 : MonoBehaviour
{
    [SerializeField] private GameObject crystal1;
    [SerializeField] private GameObject crystal2;
    [SerializeField] private GameObject crystal3;
    [SerializeField] private GameObject crystal4;
    [SerializeField] private ParticleSystem Forestbecon;
    [SerializeField] private GameObject firstMemory;
    [SerializeField] private GameObject pathTrigger1;
    [SerializeField] private GameObject pathTrigger2;
    [SerializeField] private GameObject pathTrigger3;
    [SerializeField] private GameObject teleporter;
    private void Start()
    {
        Forestbecon.Pause();
        firstMemory.SetActive(false);
        teleporter.SetActive(false);
        pathTrigger1.SetActive(false);
        pathTrigger2.SetActive(false);
        pathTrigger3.SetActive(false);
    }
    private void Update()
    {
        if (crystal1 == false && crystal2 == false && crystal3 == false && crystal4 == false)
        {
            Forestbecon.Play();
        }
        if(firstMemory == false)
        {
            teleporter.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            firstMemory.SetActive(true);
            pathTrigger1.SetActive(true);
            pathTrigger2.SetActive(true);
            pathTrigger3.SetActive(true);
        }
    }
}
