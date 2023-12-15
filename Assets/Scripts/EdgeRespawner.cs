using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeRespawner : MonoBehaviour
{
    public Vector3 respawnPoint;

    // EXERCISE 4-2: Modify the method below.
    private void OnTriggerEnter(Collider other) 
    {
        other.transform.position = respawnPoint;
    }
}
