using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform startPoint, endPoint;
    [SerializeField] private float changeDirectionDelay;
    private Transform destinationTarget, departTarget;

    private float startTime;
    private float pathLength;
    public bool isWaiting;
    void Start()
    {
        departTarget = startPoint;
        destinationTarget = endPoint;
        startTime = Time.time;
        pathLength = Vector3.Distance(departTarget.position, destinationTarget.position);
    }
    void FixedUpdate()
    {
        Move();   
    }
    private void Move()
    {
        if (!isWaiting)
        {
            if (Vector3.Distance(transform.position, destinationTarget.position) > 0.01f)
            {
                float distCovered = (Time.time - startTime) * speed;
                float fractionOfPath = distCovered / pathLength;
                transform.position = Vector3.Lerp(departTarget.position, destinationTarget.position, fractionOfPath);
            }
            else
            {
                isWaiting = true;
                StartCoroutine(changeDelay());
            }
        }
    }
    private void ChangeDestination()
    {
        if(departTarget == endPoint && destinationTarget == startPoint)
        {
            departTarget = startPoint;
            destinationTarget = endPoint;
        }
        else
        {
            departTarget = endPoint;
            destinationTarget = startPoint;
        }
    }

    IEnumerator changeDelay()
    {
        yield return new WaitForSeconds(changeDirectionDelay);
        ChangeDestination();
        startTime = Time.time;
        pathLength = Vector3.Distance(departTarget.position, destinationTarget.position);
        isWaiting = false;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.parent = transform;
        }
    }
}
