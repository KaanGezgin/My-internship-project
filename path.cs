using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [SerializeField] private GameObject firstPath;
    private void Start()
    {
        string path = "Paths";
        GameObject[] taggedpaths = GameObject.FindGameObjectsWithTag(path);
        firstPath.SetActive(false);
        foreach (GameObject tagged in taggedpaths)
        {
            tagged.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        string path = "Paths";
        GameObject[] taggedpaths = GameObject.FindGameObjectsWithTag(path);

        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject tagged in taggedpaths)
            {
                tagged.GetComponent<MeshRenderer>().enabled = true;
                firstPath.SetActive(true);
            }
        }
    }
}