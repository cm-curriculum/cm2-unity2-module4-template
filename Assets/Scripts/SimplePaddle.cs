using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePaddle : MonoBehaviour
{
    public float speed = 1;
    public float moveDistance = 3;
    public float launchPower = 1;
    [Range(0,90)]
    public float launchAngleRange = 5;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = this.transform.position;
    }

    void Update()
    {
        this.transform.position = startPosition + Vector3.right*moveDistance*Mathf.Sin(Time.time * speed);
    }

    // EXERCISE 4-2: Modify the method below.
    private void OnCollisionEnter(Collision other) 
    {
        other.rigidbody.AddForce(Vector3.up*launchPower, ForceMode.Impulse);
    }

    // EXERCISE 4-2: Modify the method below.
    private void OnCollisionExit(Collision other) 
    {
        float randomAngle = Random.Range(90-launchAngleRange, 90+launchAngleRange) * Mathf.Deg2Rad;
        Debug.Log(randomAngle);
        
        other.rigidbody.AddForce(new Vector3(Mathf.Cos(randomAngle), Mathf.Sin(randomAngle)), ForceMode.Impulse);
    }
}
