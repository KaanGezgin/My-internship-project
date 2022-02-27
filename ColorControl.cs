using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorControl : MonoBehaviour
{
    [SerializeField] private GameObject control1;
    [SerializeField] private GameObject control2;
    [SerializeField] private GameObject control3;
    [SerializeField] private GameObject control4;
    [SerializeField] private ParticleSystem becon;
    [SerializeField] private GameObject MemControl;
    void Start()
    {
        becon.Pause();
    }
    void LateUpdate()
    {
        if(control1 == false && control2 == false && control3 == false && control4 == false)
        {
            Destroy(MemControl);
            becon.Play();
        }
    }
}
