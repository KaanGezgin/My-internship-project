using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPathway : MonoBehaviour
{
    [SerializeField] private Vector3 spinner;
    [SerializeField] private float yaxis;

    void Update()
    {
        transform.Rotate(0, yaxis * Time.deltaTime,0, 0.0f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = transform;
        }
    }
}
