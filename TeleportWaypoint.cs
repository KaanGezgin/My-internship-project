using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportWaypoint : MonoBehaviour
{
    public Transform location1;
    public Transform teleportLocation;
    bool CheckForCharacterController(Transform target)
    {
        if (target.GetComponent<CharacterController>())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void MoveFirstLocation(Transform target)
    {
        if (CheckForCharacterController(target))
        {
            target.gameObject.GetComponent<CharacterController>().enabled = false;
            target.position = location1.position;
            target.gameObject.GetComponent<CharacterController>().enabled = true;
        }
        else
        {
            target.position = location1.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.transform.position = teleportLocation.position;
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
        else
        {
            other.transform.position = teleportLocation.position;

        }
    }
}
