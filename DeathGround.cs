using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathGround : MonoBehaviour
{
    public Vector3 checkpoint;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = checkpoint;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
