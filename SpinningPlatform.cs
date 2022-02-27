using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningPlatform : MonoBehaviour
{
    [SerializeField] private float zaxis;
    void Update()
    {
        transform.Rotate(0, 0, zaxis * Time.deltaTime, 0.0f);
    }
}
