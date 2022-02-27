using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Collider tpCollider;
    [SerializeField] private ParticleSystem beam;

    private void Start()
    {
        tpCollider.isTrigger = false;
        beam.Pause();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tpCollider.isTrigger = true;
            beam.Play();
        }
    }

}
