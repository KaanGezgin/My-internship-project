using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource Terrain;// Gidilecek b�lge
    [SerializeField] private AudioSource Terrain2;// Prologue b�lgesi
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Terrain.enabled = true;
            Terrain2.enabled = false;
        }
    }
}
