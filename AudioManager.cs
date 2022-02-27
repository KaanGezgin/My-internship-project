using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource Terrain;// Gidilecek bölge
    [SerializeField] private AudioSource Terrain2;// Prologue bölgesi
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Terrain.enabled = true;
            Terrain2.enabled = false;
        }
    }
}
