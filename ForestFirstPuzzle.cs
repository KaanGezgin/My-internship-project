using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestFirstPuzzle : MonoBehaviour
{
   private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    
}
