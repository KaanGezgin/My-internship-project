using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public DeathGround deathGround; 
    public Collider checkP;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deathGround.checkpoint = other.transform.position;
            checkP.enabled = false;
        }
    }
}
