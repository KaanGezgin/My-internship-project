using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedP : MonoBehaviour
{

    [SerializeField] private Material material;
    [SerializeField] private GameObject control;
    [SerializeField] private int num;
    [SerializeField] private bool colorControl;
    [SerializeField] private int numS;

    void Start()
    {
        numS = Random.Range(0, 4);
        switch (numS)
        {
            case 0:
                material.color = Color.red;
                colorControl = true;
                break;
            case 1:
                material.color = Color.magenta;
                colorControl = false;
                break;
            case 2:
                material.color = Color.green;
                colorControl = false;
                break;
            case 3:
                material.color = Color.yellow;
                colorControl = false;
                break;
        }
    }
    void Update()
    {
        if (colorControl)
        {
            Destroy(control);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        num = Random.Range(0, 4);

        if (colorControl == false)
        {
            switch (num)
            {
                case 0:
                    Debug.Log("1");
                    if (other.CompareTag("Player"))
                    {
                        material.color = Color.red;
                        colorControl = true;
                    }
                    break;
                case 1:
                    Debug.Log("2");
                    if (other.CompareTag("Player"))
                    {
                        material.color = Color.magenta;
                        colorControl = false;
                    }
                    break;
                case 2:
                    Debug.Log("3");
                    if (other.CompareTag("Player"))
                    {
                        material.color = Color.green;
                        colorControl = false;
                    }
                    break;
                case 3:
                    Debug.Log("4");
                    if (other.CompareTag("Player"))
                    {
                        material.color = Color.yellow;
                        colorControl = false;
                    }
                    break;
            }
        }
    }
}